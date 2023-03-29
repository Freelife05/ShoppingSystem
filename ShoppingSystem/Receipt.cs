using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    internal class Receipt
    {
        private string customerName;

        public Receipt(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName { get => customerName; set => customerName = value; }

        public void AddProduct(Product product)
        {
            
        }

        public override string ToString()
        {
            return "";
        }
    }
}
