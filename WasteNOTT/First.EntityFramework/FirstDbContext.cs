using First.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.EntityFramework
{
    public class FirstDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<OrderDetails>  OrderDetails { get; set; }
        public DbSet<ShippingInfo> ShippingInfo { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().OwnsOne(a => a.Account);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FirstDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
