using Microsoft.EntityFrameworkCore;

namespace UniformAccountingSystem.Data
{
    public class UniformAccountiongContext : DbContext
    {
        public UniformAccountiongContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }
    }
}
