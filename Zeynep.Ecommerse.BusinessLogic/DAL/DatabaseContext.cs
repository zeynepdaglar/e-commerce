using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeynep.Ecommerse.BusinessLogic.DAL;

namespace Zeynep.Ecommerse.BusinessLogic.DAL
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<GlobalException> GlobalExceptions { get; set; }


        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }



        public DbSet<Zeynep.Ecommerse.BusinessLogic.DAL.Category> Category { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
