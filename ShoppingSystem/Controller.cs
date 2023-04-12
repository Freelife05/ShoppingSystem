using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return $"Created new Physical Product";
        }

        public string Service(List<string> args)
        {
            string name = args[0];
            double price = double.Parse(args[1]);
            double weight = double.Parse(args[2]);
            products.Add(new ServiceProduct(name, price, weight));
            return $"Created new Service Product";
        }

        public string Checkout(List<string> args)
        {
            Receipt receipt = new Receipt(args[0]);
            foreach (var item in products)
            {
                receipt.AddProduct(item);
            }
            receipts.Add(receipt);
            products.Clear();
            return "Checked out";
        }

        public string Info(List<string> args)
        {
            string info = args[0];
            string fullInfo = "";
            if (info == "Customer")
            {
                foreach (var item in products)
                {
                    fullInfo += $"{item.ToString()}\n";
                }
                return fullInfo;
            }
            else if (info == "Shop")
            {
                foreach (var item in receipts)
                {
                    fullInfo += $"{item.ToString()}\n";
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
            Console.WriteLine($"Amount of customers; {receipts.Count}");
            Environment.Exit(0);
            return "";
        }
    }
}