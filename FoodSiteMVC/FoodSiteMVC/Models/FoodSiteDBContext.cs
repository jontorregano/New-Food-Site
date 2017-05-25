using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodSiteMVC.Models
{
    public class FoodSiteDBContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Foods> Foods { get; set; }
    }
}