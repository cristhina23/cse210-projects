using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("************Welcome!***********");
        Console.WriteLine("-------------------------------");
        
        Console.WriteLine();

        Address address1 = new Address("123 Main St", "New York", "NY", "10001", "USA");
        Address address2 = new Address("456 Avenue", "Lima", "Lima", "15001", "Peru");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Maria Perez", address2);

        Product product1 = new Product("Laptop", 1,1, 1000.0f );
        Product product2 = new Product("Mouse", 2, 2, 50.0f);
        Product product3 = new Product("Keyboard", 3, 2, 100.0f);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());

        Console.WriteLine("-------------------------------");
        Console.WriteLine("************Goodbye!***********");
        Console.WriteLine("-------------------------------");
    }
}