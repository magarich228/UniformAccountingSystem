using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<UniformVendor>
    {
        public void Configure(EntityTypeBuilder<UniformVendor> builder)
        {
            builder.HasKey(v => v.Id);

            builder.HasAlternateKey(v => v.Name);

            builder.HasAlternateKey(v => v.Phone);

            builder.Property(v => v.Phone)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(v => v.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(v => v.Email)
                .HasMaxLength(100);

            builder.Property(v => v.Description)
                .HasMaxLength(200);
        }
    }
}
