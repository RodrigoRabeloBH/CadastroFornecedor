using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasColumnType("varchar(120)").HasMaxLength(120);
            builder.Property(p => p.Description).IsRequired().HasColumnType("varchar(400)").HasMaxLength(400);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p=>p.ImageUrl).IsRequired().HasColumnType("varchar(200)").HasMaxLength(200);          
        }
    }
}