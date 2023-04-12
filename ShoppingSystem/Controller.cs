using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    internal class Controller
    {
        private List<Product> products = new List<Product>();
        private List<Receipt> receipts = new List<Receipt>();

        public string Product(List<string> args)
        {
            string name = args[0];
            double price = double.Parse(args[1]);
            double weight = double.Parse(args[2]);
            products.Add(new PhysicalProduct(name, price, weight));
            return $"The current customer has bought {name}";
        }

        public string Service(List<string> args)
        {
            string name = args[0];
            double price = double.Parse(args[1]);
            double weight = double.Parse(args[2]);
            products.Add(new ServiceProduct(name, price, weight));
            return $"The current customer has applied for {name} service";
        }

        public string Checkout(List<string> args)
        {
            Receipt receipt = new Receipt(args[0]);
            double total = 0;
            foreach (var item in products)
            {
                receipt.AddProduct(item);
                total += item.Price;
            }
            receipts.Add(receipt);
            products.Clear();
            return $"Total Bill: ${Math.Round(total,2)}";
        }

        public string Info(List<string> args)
        {
            string info = args[0];
            string fullInfo = "";
            if (info == "Customer")
            {
                fullInfo += $"Current customer has:\n";
                fullInfo += $"Products: {products.Count}";
                return fullInfo;
            }
            else if (info == "Shop")
            {
                fullInfo += "Receipts: \n";
                if (receipts.Count == 0)
                {
                    fullInfo += "No receipts";
                }
                else
                {
                    foreach (var item in receipts)
                    {
                        fullInfo += $"{item.ToString()}\n";
                    }
                }
                return fullInfo;
            }
            else
            {
                return "Invalid Input";
            }
        }

        public string End()
        {
            Console.WriteLine($"Total customers: {receipts.Count}");
            Environment.Exit(0);
            return "";
        }
    }
}