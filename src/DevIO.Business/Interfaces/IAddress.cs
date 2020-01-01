using System;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IAddress : IRepository<Address>
    {
        Task<Address> GetAddressByProvider(Guid providerId);
    }
}