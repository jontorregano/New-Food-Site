using System.Data.Entity;

namespace FoodSiteMVC.Models
{
    public class FoodSiteDBContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Foods> Foods { get; set; }
    }
}