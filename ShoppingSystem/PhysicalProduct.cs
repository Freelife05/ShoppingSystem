using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShoppingSystem
{
    internal class PhysicalProduct : Product
    {
        private double weight;

        public double Weight { get => weight; set => weight = value; }

        public PhysicalProduct(string name, double price, double weight) : base(name, price)
        {
            Weight = weight;
            if (Weight <= 0)
            {
                throw new ArgumentException(String.Format("Weight cannot be less or equal to 0!"));
            }

            if (name.Length < 3 && name.Length > 30)
            {
                throw new ArgumentException(String.Format("Name should be between 3 and 30 characters!"));
            }
            if (Price < 0)
            {
                throw new ArgumentException(String.Format("Price should be 0 or positive!"));
            }
        }

        public override string ToString()
        {
            return $"The product's Name is {Name}, its price is {Price} and its weight is {weight}";
        }
    }
}
