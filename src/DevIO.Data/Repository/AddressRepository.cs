using System;
using System.Threading.Tasks;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddress
    {
        public AddressRepository(DataContext context) : base(context) { }

        public async Task<Address> GetAddressByProvider(Guid providerId)
        {
            return await _context.Addresses
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.ProviderId == providerId);
        }
    }
}