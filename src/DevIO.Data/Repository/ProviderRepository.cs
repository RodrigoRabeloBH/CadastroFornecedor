using System;
using System.Threading.Tasks;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class ProviderRepository : Repository<Provider>, IProvider
    {
        public ProviderRepository(DataContext context) : base(context) { }
        
        public async Task<Provider> GetProviderAddressById(Guid id)
        {
            return await _context.Providers
                .AsNoTracking()
                .Include(p => p.Address)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Provider> GetProviderProductsAddressById(Guid id)
        {
            return await _context.Providers
                .AsNoTracking()
                .Include(p => p.Address)
                .Include(p => p.Products)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}