using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    internal class ServiceProduct : Product
    {
        private double time;

        public ServiceProduct(string name, double price, double time) : base(name, price)
        {
            Time = time;
        }

        public double Time { get => time; set => time = value; }

        public override string ToString()
        {
            return "";
        }
    }
}
