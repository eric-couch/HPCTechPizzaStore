using HPCTechPizzaStore.Data;
using HPCTechPizzaStore.Models;

using (StoreContext _context = new StoreContext())
{
    //Product pepperoniPizza = _context.Products.Where(p => p.Name == "Pepperoni Pizza").FirstOrDefault()!;  

    //Product pepperoniPizza = (from p in _context.Products
    //                          where p.Name == "Pepperoni Pizza"
    //                          select p).FirstOrDefault()!;

    // use Ef core caching, if not cached, it will use Index in DB
    Product pepperoniPizza = _context.Products.Find(1)!;


    if (pepperoniPizza is not null)
    {
        //pepperoniPizza.Price = 10.99M;
        //Console.WriteLine("Updating Pepperoni Pizza price to $10.99");
        _context.Products.Remove(pepperoniPizza);
    }
    
    _context.SaveChanges();
    
    List<Product> products = (from p in _context.Products 
                              where p.Price > 10.00M 
                              select p).ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"Id:\t{product.Id}");
        Console.WriteLine($"Name:\t{product.Name}");
        Console.WriteLine($"Price:\t{product.Price}");
        Console.WriteLine(new string('-', 20));
    }
                    
}
