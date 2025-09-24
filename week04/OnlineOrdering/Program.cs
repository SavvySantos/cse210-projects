using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("");

        Address address1 = new Address("543 N Mule Train", "Enoch", "UT", null, "USA");
        Customer customer1 = new Customer("Savanah Santos", address1);

        Product product1 = new Product("TV", 159753, 699.99m, 1);
        Product product2 = new Product("BlueRay", 123654, 125.99m, 1);
        Product product3 = new Product("Movies", 741258, 14.99m, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("410 12th St", "Carrizozo", "NM", null, "USA");
        Customer customer2 = new Customer("Julio Sanchez", address2);
        
        Product product4 = new Product("Car Coding", 258963, 29.95m, 2);
        Product product5 = new Product("Drill Bits", 456789, 17.46m, 4);
        Product product6 = new Product("Water Hose", 456852, 35.00m, 1);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        Console.WriteLine("----Packing Label----");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("----Shipping Label----");
        Console.WriteLine(order1.GetShippingLabel());

        order1.DisplayAll();

        decimal order1Total = order1.GetTotalCost();
        Console.WriteLine("");

        Console.WriteLine($"Total Order Price: ${order1Total:F2}");

        Console.WriteLine("_______________________________________");
        
                Console.WriteLine("----Packing Label----");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("----Shipping Label----");
        Console.WriteLine(order2.GetShippingLabel());

        order2.DisplayAll();

        decimal order2Total = order2.GetTotalCost();
        Console.WriteLine("");

        Console.WriteLine($"Total Order Price: ${order2Total:F2}");

        Console.WriteLine("");
    }
}
