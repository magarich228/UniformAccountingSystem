using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class UniformConfiguration : IEntityTypeConfiguration<Uniform>
    {
        public void Configure(EntityTypeBuilder<Uniform> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasAlternateKey(u => u.Name);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Price)
                .IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_Uniform_Price", "Price > 0"));

            builder.Property(u => u.UniformType)
                .IsRequired()
                .HasDefaultValue(UniformType.Other);

            builder.HasOne<UniformTypeRef>(u => u.UniformTypeRef)
                .WithMany();
        }
    }
}
