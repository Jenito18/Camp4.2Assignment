namespace ConsoleAppFileHandlingQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list 
            List<Product> products = new List<Product>();

            // Manually adding 10 products to the list
            products.Add(new Product(100, "Apple", 1.20, 30));
            products.Add(new Product(101, "Banana", 0.80, 50));
            products.Add(new Product(102, "Orange", 1.10, 40));
            products.Add(new Product(103, "Mango", 1.50, 20));
            products.Add(new Product(104, "Grapes", 2.00, 15));
            products.Add(new Product(105, "Pineapple", 3.00, 10));
            products.Add(new Product(106, "Strawberry", 2.50, 25));
            products.Add(new Product(107, "Blueberry", 4.00, 5));
            products.Add(new Product(108, "Watermelon", 1.00, 8));
            products.Add(new Product(109, "Papaya", 1.70, 12));

            //File path to store

            string filePath = "product.csv";

            // Creating a StreamWriter to write in the created file

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Writing the header line 

                writer.WriteLine("ProductId,ProductName,ProductPrice,Quantity");

                // foreach to loop to write every given product
                foreach (var product in products)
                {
                    writer.WriteLine(product.ProductList());
                }
            }

            // showing output to user
            Console.WriteLine($"Product details have been saved to {filePath} sucessfully;;");

            Console.ReadKey();
        }
    }
}