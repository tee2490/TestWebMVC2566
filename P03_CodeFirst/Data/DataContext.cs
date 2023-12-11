using Microsoft.EntityFrameworkCore;
using P03_CodeFirst.Models;

namespace P03_CodeFirst.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=TestProduct67; Trusted_Connection=True; TrustServerCertificate=True");
            //optionsBuilder.UseSqlite("Data Source=TestProduct67.db");
        }

        public DbSet<Product> Products { get; set; }


    }
}
