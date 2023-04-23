using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class UniformIssuanceConfiguration : IEntityTypeConfiguration<UniformIssuance>
    {
        public void Configure(EntityTypeBuilder<UniformIssuance> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.IssuanceDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(i => i.Desctiption)
                .HasMaxLength(200);

            builder.Property(i => i.IssuanceAction)
                .HasDefaultValue(IssuanceAction.Issuance);
        }
    }
}
