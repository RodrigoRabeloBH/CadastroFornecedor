using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using DevIo.App.Models;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.App.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProduct _repository;
        private readonly IProvider _provider;
        private readonly IMapper _mapper;

        private readonly IHostingEnvironment _env;

        public ProductController(IProduct repository, IMapper mapper, IHostingEnvironment env, IProvider provider)
        {
            _repository = repository;
            _mapper = mapper;
            _env = env;
            _provider = provider;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var list = _mapper.Map<List<ProductViewModel>>(await _repository.GetProdutsAndProvider());

            var model = new ProductIndexViewModel
            {
                Products = list
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            var model = _mapper.Map<ProductViewModel>(await _repository.GetProductProvider(id));
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var providers = _mapper.Map<List<ProviderViewModel>>(await _provider.GetAll());

            var model = new ProductViewModel
            {
                Providers = providers
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel productViewModel)
        {

            productViewModel.Providers = _mapper.Map<List<ProviderViewModel>>(await _provider.GetAll());

            if (!ModelState.IsValid) return View(productViewModel);

            if (productViewModel.Image == null) return View(productViewModel);

            string imageName = Guid.NewGuid() + "_" + productViewModel.Image.FileName;

            string imageUrl = $"images/products/{imageName}";

            await UploadImage(productViewModel, imageName);

            productViewModel.ImageUrl = imageUrl;
            productViewModel.Created = DateTime.Now;

            await _repository.Add(_mapper.Map<Product>(productViewModel));

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = _mapper.Map<ProductViewModel>(await _repository.GetById(id));
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductViewModel productViewModel)
        {
            var product = await _repository.GetById(productViewModel.Id);

            if (!ModelState.IsValid) return View(productViewModel);

            if (productViewModel.Image != null)
            {
                await DeleteFile(productViewModel);

                string imageName = Guid.NewGuid() + "_" + productViewModel.Image.FileName;

                string imageUrl = $"images/products/{imageName}";

                await UploadImage(productViewModel, imageName);

                productViewModel.ImageUrl = imageUrl;
            }
            else
            {
                productViewModel.ImageUrl = product.ImageUrl;
            }

            productViewModel.Created = product.Created;
           
            productViewModel.ProviderId = product.ProviderId;
           

            await _repository.Edit(_mapper.Map<Product>(productViewModel));

            return RedirectToAction("Detail", new { id = productViewModel.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = _mapper.Map<ProductViewModel>(await _repository.GetById(id));
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductViewModel productViewModel)
        {
            await DeleteFile(productViewModel);
            await _repository.Delete(_mapper.Map<Product>(productViewModel));
            return RedirectToAction("Index");
        }

        private async Task UploadImage(ProductViewModel productViewModel, string imageName)
        {
            if (productViewModel.Image != null)
            {
                string uploadFolder = Path.Combine(_env.WebRootPath, "images/products");
                string filePath = Path.Combine(uploadFolder, imageName);

                using (var stream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    await productViewModel.Image.CopyToAsync(stream);
                }
            }
        }

        private async Task<ProductViewModel> GetProduct(Guid id)
        {
            var product = _mapper.Map<ProductViewModel>(await _repository.GetProductProvider(id));
            product.Providers = _mapper.Map<List<ProviderViewModel>>(await _provider.GetAll());
            return product;
        }

        private async Task DeleteFile(ProductViewModel productViewModel)
        {
            var product = await _repository.GetById(productViewModel.Id);

            DirectoryInfo dir = new DirectoryInfo(Path.Combine(_env.WebRootPath, "images/products"));

            FileInfo[] file = dir.GetFiles("*", SearchOption.AllDirectories);

            string imageName = product.ImageUrl.Substring(product.ImageUrl.LastIndexOf('/') + 1);

            foreach (var image in file) if (imageName == image.Name) image.Delete();
        }
    }
}