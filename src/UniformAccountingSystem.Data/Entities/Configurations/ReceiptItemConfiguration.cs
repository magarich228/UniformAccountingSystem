using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class ReceiptItemConfiguration : IEntityTypeConfiguration<ReceiptItem>
    {
        public void Configure(EntityTypeBuilder<ReceiptItem> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Amount)
                .HasDefaultValue(1);

            builder.ToTable(t => t.HasCheckConstraint("CK_ReceiptItem_Amount", "Amount > 0"));
        }
    }
}
