using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class ProviderMapping : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasColumnType("varchar(120)").HasMaxLength(120);
            builder.Property(p => p.Document).IsRequired().HasColumnType("varchar(14)").HasMaxLength(14);
            builder.HasOne(p => p.Address).WithOne(a => a.Provider);
            builder.HasMany(p => p.Products).WithOne(Product => Product.Provider).HasForeignKey(Product => Product.ProviderId);
        }
    }
}