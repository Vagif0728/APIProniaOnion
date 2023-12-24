using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pronia.Domain.Entities;

namespace Pronia.Persistence.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(6,2)");
            builder.Property(x => x.Description).IsRequired(false).HasColumnType("text");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.SKU).IsRequired().HasMaxLength(10);
        }
    }
}
