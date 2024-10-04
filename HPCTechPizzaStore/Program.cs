using HPCTechPizzaStore;
using HPCTechPizzaStore.Data;
using HPCTechPizzaStore.Models;

// customer lookup
// view products
// Order Creation

// CUSTOMER LOOKUP
// get name/phone number
Customer newCustomer = new Customer();
OrderService thisOrder = new OrderService();

// Gather Customer info
Customer thisCustomer = OrderService.GetNewCustomerInfo(newCustomer);

var findCustomer = thisOrder.FindCustomer(thisCustomer);

if (findCustomer is null)
{
    findCustomer = thisOrder.CreateCustomer(thisCustomer);
}

Console.WriteLine($"First Name: {findCustomer.FirstName ?? ""}");
Console.WriteLine($"Last Name: {findCustomer.LastName}");
Console.WriteLine($"Phone: {findCustomer.Phone}");
Console.WriteLine($"Addres: {findCustomer.Address}");

// what pizza do you want?
// main order loop
