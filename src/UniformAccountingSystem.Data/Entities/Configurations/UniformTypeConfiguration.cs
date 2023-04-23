using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class UniformTypeConfiguration : IEntityTypeConfiguration<UniformTypeRef>
    {
        public void Configure(EntityTypeBuilder<UniformTypeRef> builder)
        {
            builder.HasKey(t => t.UniformType);

            List<UniformTypeRef> types = new List<UniformTypeRef>();

            foreach (var type in Enum.GetValues<UniformType>())
            {
                types.Add(new UniformTypeRef(type));
            }

            builder.HasData(types);
        }
    }
}
