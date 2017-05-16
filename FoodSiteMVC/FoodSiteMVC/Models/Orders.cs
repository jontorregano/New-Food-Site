using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace FoodSiteMVC.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class OrdersDBContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
    }
}