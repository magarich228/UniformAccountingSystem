using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class UniformReceiptConfiguration : IEntityTypeConfiguration<UniformReceipt>
    {
        public void Configure(EntityTypeBuilder<UniformReceipt> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.ReceiptDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(r => r.Desctiption)
            .HasMaxLength(200);
        }
    }
}
