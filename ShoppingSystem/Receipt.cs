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

        public string CustomerName 
        { 
            get { return customerName; }
            set
            {
                if (value.Length <= 40 && value.Length >= 2)
                {
                    customerName = value;
                }
                else 
                {
                    throw new InvalidProgramException("Name must be between 2 and 40 characters!");
                }
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);  
        }

        public override string ToString()
        {
            double totalPrice = 0;
            string fullString = "";
            foreach (var item in products) 
            {
                totalPrice += item.Price;
                fullString += $"Name: {item.Name}\n";
                fullString += $"Price: {item.Price}\n";
                fullString += $"{item.ToString()}\n";
            }
            return $"Receipt of {customerName}\n" +
                $"Total Price: {totalPrice}\n" +
                $"Products:\n" +
                $"{fullString}\n";
        }
    }
}
