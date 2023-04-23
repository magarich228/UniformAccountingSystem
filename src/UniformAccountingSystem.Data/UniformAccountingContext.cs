using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.Data.Entities;

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


            base.OnModelCreating(modelBuilder);
        }
    }
}
