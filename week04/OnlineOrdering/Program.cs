using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Mary Alvarez", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", 2.50, 3));
        order1.AddProduct(new Product("Pencil", 1, 10));
        order1.AddProduct(new Product("Markers", 3.33, 5));
        order1.AddProduct(new Product("Sketchbook", 4.50, 3));

        Console.WriteLine($"Address: {address1.GetAddress()}");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Address address2 = new Address("Calle Vargas", "Barquisimeto", "Lara", "Venezuela");
        Customer customer2 = new Customer("Armando Casas", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Coca-Cola", 2.99, 2));
        order2.AddProduct(new Product("Sprite", 1.23, 3));
        order2.AddProduct(new Product("Tostones de Limon", 3.33, 6));
        order2.AddProduct(new Product("Doritos", 2.22, 4));
        order2.AddProduct(new Product("Popcorn", 1.55, 3));

        Console.WriteLine($"Address: {address2.GetAddress()}");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
        
    }
}