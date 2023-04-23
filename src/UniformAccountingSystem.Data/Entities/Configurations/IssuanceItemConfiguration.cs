using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class IssuanceItemConfiguration : IEntityTypeConfiguration<IssuanceItem>
    {
        public void Configure(EntityTypeBuilder<IssuanceItem> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Amount)
                .HasDefaultValue(1);

            builder.ToTable(t => t.HasCheckConstraint("CK_IssuanceItem_Amount", "Amount > 0"));
        }
    }
}
