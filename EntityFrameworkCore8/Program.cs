using EntityFrameworkCore8;
using Microsoft.EntityFrameworkCore;

using var context = new MyDbContext();
context.Database.EnsureCreated(); // Ensure database is created

// Adding products with JSON attributes
var products = new List<Product>
        {
            new Product { Name = "Product A", Price = 10.99M, AttributesJson = "{\"color\": \"red\", \"size\": \"M\"}" },
            new Product { Name = "Product B", Price = 15.49M, AttributesJson = "{\"color\": \"blue\", \"size\": \"L\"}" }
        };

context.Products.AddRange(products);
context.SaveChanges();

// Querying products
var allProducts = context.Products.ToList();
Console.WriteLine("All Products:");
foreach (var product in allProducts)
{
    Console.WriteLine($"{product.Id}: {product.Name} - ${product.Price}, Attributes: {product.AttributesJson}");
}

// Bulk operation: Add new orders
var orders = new List<Order>
        {
            new Order { ProductId = 1, OrderDate = DateTime.UtcNow },
            new Order { ProductId = 2, OrderDate = DateTime.UtcNow }
        };
context.Orders.AddRange(orders);
context.SaveChanges();

// Querying orders
var allOrders = context.Orders.Include(o => o.Product).ToList();
Console.WriteLine("\nAll Orders:");
foreach (var order in allOrders)
{
    Console.WriteLine($"Order {order.Id}: {order.Product.Name} on {order.OrderDate}");
}
