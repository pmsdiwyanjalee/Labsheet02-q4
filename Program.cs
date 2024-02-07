using System;

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate objects using the constructor
        Product product1 = new Product("Laptop", 999.99);
        Product product2 = new Product("Smartphone", 599.99);
        Product product3 = new Product("Headphones", 49.99);

        // Display product details
        Console.WriteLine("Product Details:");
        Console.WriteLine($"Product 1: {product1.ProductName}, Price: ${product1.Price}");
        Console.WriteLine($"Product 2: {product2.ProductName}, Price: ${product2.Price}");
        Console.WriteLine($"Product 3: {product3.ProductName}, Price: ${product3.Price}");
    }
}