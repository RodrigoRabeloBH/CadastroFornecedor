using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProduct
    {
        public ProductRepository(DataContext context) : base(context) { }
        public async Task<Product> GetProductProvider(Guid id)
        {
            return await _context.Products
                .AsNoTracking()
                .Include(p => p.Provider)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProdutsAndProvider()
        {
            return await _context.Products
                .AsNoTracking()
                .Include(p => p.Provider)
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProdutsByProviderId(Guid providerId)
        {
            return await _context.Products
                .AsNoTracking()
                .Where(p => p.ProviderId == providerId)
                .ToListAsync();
        }
    }
}