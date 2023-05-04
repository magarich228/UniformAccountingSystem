using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UniformAccountingSystem.Data.Entities.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.State)
                .HasDefaultValue(EmployeeState.Active);

            builder.Property(e => e.WorkPosition)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasData(new Employee[]
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Александр",
                    LastName = "Черепанов",
                    Patronymic = "Петрович",
                    State = EmployeeState.Active,
                    WorkPosition = "роблоксер"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Вячеслав",
                    LastName = "Горелов",
                    Patronymic = "Антонович",
                    State = EmployeeState.Active,
                    WorkPosition = "разработчик"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Валерия",
                    LastName = "Косынкова",
                    Patronymic = "Дмитриевна",
                    State = EmployeeState.Active,
                    WorkPosition = "грузчик"
                },
            });
        }
    }
}
