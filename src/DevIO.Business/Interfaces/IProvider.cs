using System;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IProvider:IRepository<Provider>
    {
         Task<Provider> GetProviderAddressById(Guid id);
         Task<Provider> GetProviderProductsAddressById(Guid id);
    }
}