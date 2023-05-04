using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.Data.Entities;
using UniformAccountingSystem.Data.Entities.Configurations;

namespace UniformAccountingSystem.Data
{
    public class UniformAccountingContext : DbContext
    {
        public DbSet<Uniform> Uniforms { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<UniformVendor> Vendors { get; set; } = null!;
        public DbSet<UniformReceipt> Receipts { get; set; } = null!;
        public DbSet<UniformIssuance> Issues { get; set; } = null!;
        public DbSet<UniformDiscard> Discards { get; set; } = null!;
        public DbSet<ReceiptItem> ReceiptItems { get; set; } = null!;
        public DbSet<IssuanceItem> IssuesItem { get; set; } = null!;
        public DbSet<UniformTypeRef> UniformTypes { get; set; } = null!;

        public UniformAccountingContext(DbContextOptions<UniformAccountingContext> optionsBuilder)
            : base(optionsBuilder)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UniformConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new VendorConfiguration());
            modelBuilder.ApplyConfiguration(new UniformTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UniformReceiptConfiguration());
            modelBuilder.ApplyConfiguration(new UniformIssuanceConfiguration());
            modelBuilder.ApplyConfiguration(new UniformDiscardConfiguration());
            modelBuilder.ApplyConfiguration(new ReceiptItemConfiguration());
            modelBuilder.ApplyConfiguration(new IssuanceItemConfiguration());

            List<UniformTypeRef> types = new List<UniformTypeRef>();

            foreach (var type in Enum.GetValues<UniformType>())
            {
                types.Add(new UniformTypeRef(type));
            }

            modelBuilder.Entity<UniformTypeRef>().HasData(types);

            var unifroms = new Uniform[]
            {
                new Uniform
                {
                    Id = Guid.NewGuid(),
                    Name = "Штаны обыкновенные",
                    Price = 800,
                    UniformType = UniformType.Other,
                },
                new Uniform
                {
                    Id = Guid.NewGuid(),
                    Name = "Костюм грузчика",
                    Price = 6000,
                    UniformType = UniformType.Suit,
                },
                new Uniform
                {
                    Id = Guid.NewGuid(),
                    Name = "Футболка роблоксера",
                    Price = 3250,
                    UniformType = UniformType.Other
                }
            };

            modelBuilder.Entity<Uniform>().HasData(unifroms);

            var vId = Guid.NewGuid();
            var rId = Guid.NewGuid();

            modelBuilder.Entity<UniformVendor>().HasData(new UniformVendor
            {
                Id = vId,
                Name = "ИП Краснореченск",
                Email = "refriver@mail.ru",
                Phone = "89505602033"
            });

            modelBuilder.Entity<UniformReceipt>().HasData(new UniformReceipt
            {
                Id = rId,
                ReceiptDate = DateTime.UtcNow,
                Desctiption = "Первая поставка",
                VendorId = vId,
            });

            modelBuilder.Entity<ReceiptItem>().HasData(new List<ReceiptItem>()
            {
                new ReceiptItem
                {
                    Id = Guid.NewGuid(),
                    Amount = 5,
                    ReceiptId = rId,
                    UniformId = unifroms.First().Id
                }
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
