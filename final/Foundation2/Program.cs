using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to 'Shopping Label & Product List'\n");

        // create address'
        Address address1 = new Address("Street1", "City1", "State1", "Country1", "Zipcode1");
        Address address2 = new Address("Street2", "City2", "State2", "Country2", "Zipcode2");

        // create customer
        Customer customer1 = new Customer("Buyer1 Name", address1);
        Customer customer2 = new Customer("Buyer2 Name", address2);

        // create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // add product to orders
        order1.AddProduct(new Product("p1", "p1-id", 7.11m, 1));
        order1.AddProduct(new Product("p2", "p2-id", 19.28m, 2));

        order2.AddProduct(new Product("p1", "p1- id", 1.65m, 3));
        order2.AddProduct(new Product("p2", "p2- id", 4.99m, 4));
        order2.AddProduct(new Product("p3", "p3-id", 625.01m, 1));

        // display packing labels
        Console.WriteLine(order1.GetPackingList());
        Console.WriteLine(order2.GetPackingList());

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}