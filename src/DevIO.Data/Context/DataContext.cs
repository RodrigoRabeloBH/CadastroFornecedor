using System.Linq;
using DevIO.Business.Models;
using DevIO.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=DevIO.App;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProviderMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());

            /*Disable Cascade delete*/

            var relationship = modelBuilder.Model
                    .GetEntityTypes()
                    .SelectMany(e => e.GetForeignKeys());

            foreach (var fk in relationship)
            {
                fk.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}