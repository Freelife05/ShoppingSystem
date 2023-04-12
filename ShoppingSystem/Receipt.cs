using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    internal class Receipt
    {
        private string customerName;
        private List<Product> products = new List<Product>();

        public Receipt(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName { get => customerName; set => customerName = value; }

        public void AddProduct(Product product)
        {
            products.Add(product);  
        }

        public override string ToString()
        {
            double totalPrice = 0;
            string allProducts = "";
            foreach (var item in products) 
            {
                totalPrice += item.Price;
                allProducts += $"{item.Name}\n";
            }
            return $"Receipt of {customerName}\n" +
                $"Total Price: {totalPrice}\n" +
                $"Products:\n" +
                $"{allProducts}";
        }
    }
}
