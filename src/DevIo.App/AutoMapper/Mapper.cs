using AutoMapper;
using DevIo.App.Models;
using DevIO.Business.Models;

namespace DevIo.App.AutoMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Provider, ProviderViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
        }
    }
}