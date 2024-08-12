using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFileHandlingQuestion3
{
    // Product class to store product details
    public class Product
    {
        // fields to store product information
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }

        // Constructor to get details
        public Product(int productId, string productName, double productPrice, int quantity)
        {
            this.ProductId = productId;

            this.ProductName = productName;

            this.ProductPrice = productPrice;

            this.Quantity = quantity;
        }

        // Method to return product details


        public string ProductList()
        {
            return ($"The product details are given: \nProductId : {ProductId},\nProductName{ProductName},\nProductPrice{ProductPrice},\nProductQuantity{Quantity}");
        }
    }
}
