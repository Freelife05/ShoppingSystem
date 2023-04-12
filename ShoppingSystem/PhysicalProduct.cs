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

        public double Weight 
        {
            get
            {
                return weight;
            }
            set
            {
                if (Weight <= 0)
                {
                    throw new ArgumentException(String.Format("Weight cannot be less or equal to 0!"));
                }
                else
                {
                    this.weight = value;
                }
            }
        }

        public PhysicalProduct(string name, double price, double weight) : base(name, price)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return String.Format($"The product's Name is {Name}, its price is {Price} and its weight is {weight}");
        }
    }
}
