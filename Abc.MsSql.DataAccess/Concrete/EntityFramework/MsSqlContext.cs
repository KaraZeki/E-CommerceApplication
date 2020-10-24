using Abc.MsSql.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Abc.MsSql.DataAccess.Concrete.EntityFramework
{
    public class MsSqlContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9JQOHOM;Database=ECommerceProject; Trusted_Connection=True");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
