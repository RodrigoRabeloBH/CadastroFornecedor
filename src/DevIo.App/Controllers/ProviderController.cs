using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DevIo.App.Models;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.App.Controllers
{
    public class ProviderController : BaseController
    {
        private readonly IProvider _repository;
        private readonly IMapper _mapper;
        private readonly IAddress _address;

        public ProviderController(IProvider repository, IMapper mapper, IAddress address)
        {
            _repository = repository;
            _mapper = mapper;
            _address = address;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var list = await _repository.GetAll();

            var providers = _mapper.Map<List<ProviderViewModel>>(list);

            var model = new ProviderIndexModel
            {
                Providers = providers
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            var provider = await _repository.GetProviderProductsAddressById(id);          

            if (provider != null)
            {
                var model = _mapper.Map<ProviderViewModel>(provider);
                return View(model);
            }
            else
                return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var provider = await _repository.GetProviderProductsAddressById(id);

            var model = _mapper.Map<ProviderViewModel>(provider);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProviderViewModel providerViewModel)
        {
            if (!ModelState.IsValid) return View(providerViewModel);

            var address = await _address.GetAddressByProvider(providerViewModel.Id);

            providerViewModel.Address.Id = address.Id;

            providerViewModel.Address.ProviderId = address.ProviderId;

            await _address.Edit(_mapper.Map<Address>(providerViewModel.Address));

            await _repository.Edit(_mapper.Map<Provider>(providerViewModel));

            return RedirectToAction("Detail", new { id = providerViewModel.Id });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProviderViewModel providerViewModel)
        {
            if (!ModelState.IsValid) return View(providerViewModel);

            await _repository.Add(_mapper.Map<Provider>(providerViewModel));

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var provider = await _repository.GetProviderAddressById(id);

            var model = _mapper.Map<ProviderViewModel>(provider);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProviderViewModel providerViewModel)
        {
            var address = await _address.GetAddressByProvider(providerViewModel.Id);

            await _address.Delete(_mapper.Map<Address>(address));

            await _repository.Delete(_mapper.Map<Provider>(providerViewModel));

            return RedirectToAction("Index");
        }
    }
}