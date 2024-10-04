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
}
