using CarStuff.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStuff.DAL
{

    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPurchase> CarPurchases { get; set; }
        public DbSet<SalesPerson> SalesPeople { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ExtraItem> Extras { get; set; }
    }
}
