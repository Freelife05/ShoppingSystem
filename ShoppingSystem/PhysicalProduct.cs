using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    internal class PhysicalProduct : Product
    {
        private double weight;

        public double Weight { get => weight; set => weight = value; }

        public PhysicalProduct(string name, double price, double weight) : base(name, price)
        {
            Weight = weight; 
        }

        public override string ToString()
        {
            return "";
        }
    }
}
