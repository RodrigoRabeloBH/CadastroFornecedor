using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a=>a.Id);
            builder.Property(a=>a.Street).IsRequired().HasColumnType("varchar(120)").HasMaxLength(120);
            builder.Property(a=>a.Number).IsRequired().HasColumnType("int").HasMaxLength(6);
            builder.Property(a=>a.Complement).HasColumnType("varchar(120)").HasMaxLength(120);
            builder.Property(a=>a.Zipcode).IsRequired().HasColumnType("varchar(8)").HasMaxLength(8);
            builder.Property(a=>a.District).IsRequired().HasColumnType("varchar(120)").HasMaxLength(120);
            builder.Property(a=>a.City).IsRequired().HasColumnType("varchar(120)").HasMaxLength(120);
            builder.Property(a=>a.State).IsRequired().HasColumnType("varchar(120)").HasMaxLength(120);
        }
    }
}