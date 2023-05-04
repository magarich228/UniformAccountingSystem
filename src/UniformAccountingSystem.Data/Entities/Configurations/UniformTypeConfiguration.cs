using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class UniformTypeConfiguration : IEntityTypeConfiguration<UniformTypeRef>
    {
        public void Configure(EntityTypeBuilder<UniformTypeRef> builder)
        {
            builder.HasKey(t => t.UniformType);
        }
    }
}
