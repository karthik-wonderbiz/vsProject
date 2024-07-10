using FirstApp.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Gender> Genders { get; set; }

    }
}
