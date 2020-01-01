using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IProduct : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProdutsByProviderId(Guid providerId);
        Task<IEnumerable<Product>> GetProdutsAndProvider();
        Task<Product> GetProductProvider(Guid id);
    }
}