using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class BooConfig : IEntityTypeConfiguration<Boo>
    {
        public void Configure(EntityTypeBuilder<Boo> builder)
        {
            builder.ToTable("boo");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Name).HasMaxLength(20).IsRequired();
        }
    }
}
