using HPCTechPizzaStore.Data;
using HPCTechPizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTechPizzaStore;

public class OrderService
{
    StoreContext _context = new StoreContext();



    public static Customer? GetNewCustomerInfo(Customer thisCustomer)
    {
        // exception handling, logging, etc.
        Console.WriteLine("Enter First Name: ");
        thisCustomer.FirstName = Console.ReadLine() ?? "";
        Console.WriteLine("Enter Last Name: ");
        thisCustomer.LastName = Console.ReadLine() ?? "";
        Console.WriteLine("Enter Phone: ");
        thisCustomer.Phone = Console.ReadLine() ?? "";

        return thisCustomer;
    }

    public Customer? CreateCustomer(Customer findCustomer)
    {
        Console.Write("Enter Address of new Customer: ");
        findCustomer.Address = Console.ReadLine() ?? "";
        Console.Write("Enter Email of new Customer: ");
        findCustomer.Email = Console.ReadLine() ?? "";

        _context.Customers.Add(findCustomer);
        _context.SaveChanges();
        return findCustomer;
    }

    public Customer? FindCustomer(Customer cust)
    {
        var foundCustomer = (from c in  _context.Customers
                             where (c.FirstName == cust.FirstName
                             && c.LastName == cust.LastName)
                             || c.Phone == cust.Phone
                             select c).FirstOrDefault();

        return foundCustomer;
    }
}
