using OrderMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace OrderMicroservice.DBContexts
{
    public class OrderContext : DbContext
    {
        public OrderContext() { }
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    OrderItemsCount = 1,
                    OrderAmount = 100,
                    AdditionalCharges = 10,
                    AdditionalChargesDescription = "Tax",
                    TotalAmount = 110,
                    PaymentStatus = 1,
                    PaymentMethod = 1,
                    CreatedOn = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedOn = null,
                    UpdatedBy = null
                });
        }
    }
}