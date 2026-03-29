namespace Online_Store_Adv_C_
{
    // Product Model
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    internal class Program
    {

        #region Task 01 : Smart Product Search
        //public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        //{
        //    return products.Where(filter).ToList();
        //}
        //static void Main(string[] args)
        //{
        //    // Product Catalog
        //    List<Product> catalog = new List<Product>
        //    {
        //        new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
        //        new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
        //        new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
        //        new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
        //        new Product { Id = 5, Name = "Food", Category = "Clothing", Price = 5, Stock = 200 },
        //        new Product { Id = 6, Name = "Coffe Beans", Category = "Food", Price = 15, Stock = 80 },
        //        new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
        //        new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
        //        new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
        //        new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
        //    };

        //    // 1. All Electronics products
        //    var electronics = SearchProducts(catalog, p => p.Category == "Electronics");
        //    // 2. Products cheaper than $50
        //    var cheapProducts = SearchProducts(catalog, p => p.Price < 50);

        //    // 3. Products in stock
        //    var inStock = SearchProducts(catalog, p => p.Stock > 0);

        //    // 4. Clothing products under $100
        //    var clothingUnder100 = SearchProducts(catalog, p =>
        //        p.Category == "Clothing" && p.Price < 100);

        //    // Print Results
        //    Console.WriteLine("=== Electronics ===");
        //    PrintProducts(electronics);

        //    Console.WriteLine("\n=== Cheap Products (< $50) ===");
        //    PrintProducts(cheapProducts);

        //    Console.WriteLine("\n=== In Stock ===");
        //    PrintProducts(inStock);

        //    Console.WriteLine("\n=== Clothing under $100 ===");
        //    PrintProducts(clothingUnder100);
        //}

        //// Helper Method to Print Products
        //public static void PrintProducts(List<Product> products)
        //{
        //    foreach (var p in products)
        //    {
        //        Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Category: {p.Category}, Price: {p.Price}, Stock: {p.Stock}");
        //    }
        //} 
        #endregion
    }


}

