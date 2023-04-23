using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class UniformDiscardConfiguration : IEntityTypeConfiguration<UniformDiscard>
    {
        public void Configure(EntityTypeBuilder<UniformDiscard> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Reason)
                .HasMaxLength(100);

            builder.Property(d => d.Amount)
                .HasDefaultValue(1);

            builder.ToTable(t => t.HasCheckConstraint("CK_UniformDiscard_Amount", "Amount > 0"));
        }
    }
}
