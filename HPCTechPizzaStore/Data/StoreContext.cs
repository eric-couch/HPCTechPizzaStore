using HPCTechPizzaStore.Models;
using Microsoft.EntityFrameworkCore;

namespace HPCTechPizzaStore.Data;

public class StoreContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HPCTechPizzaStore;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 1,
                Name = "Pepperoni Pizza",
                Price = 9.99M
            });
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 2,
                Name = "Meat Pizza",
                Price = 10.99M
            });
        modelBuilder.Entity<Customer>().HasData(new Customer()
        {
            Id = 1,
            FirstName = "Eric",
            LastName = "Couch",
            Address = "201 Shaffner St.",
            Phone = "(817) 304-9048",
            Email = "eric.couch@cognizant.com"
        });
        modelBuilder.Entity<Order>().HasData(new Order()
        {
            Id = 1,
            OrderPlaced = new DateTime(2024, 9, 4, 10, 30, 00),
            OrderFulfulled = new DateTime(2024, 9, 4, 11, 00, 00),
            CustomerId = 1
        });
        modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail()
        {
            Id = 1,
            Quantity = 1,
            ProductId = 2,
            OrderId = 1
        });
        modelBuilder.Entity<Order>().HasData(new Order()
        {
            Id = 2,
            OrderPlaced = new DateTime(2024, 9, 7, 18, 30, 00),
            OrderFulfulled = new DateTime(2024, 9, 7, 19, 00, 00),
            CustomerId = 1
        });
        modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail()
        {
            Id = 2,
            Quantity = 1,
            ProductId = 2,
            OrderId = 2
        });
    }
}
