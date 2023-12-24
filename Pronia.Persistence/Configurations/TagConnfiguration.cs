using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pronia.Domain.Entities;

namespace Pronia.Persistence.Configurations
{
    internal class TagConnfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(25);
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
