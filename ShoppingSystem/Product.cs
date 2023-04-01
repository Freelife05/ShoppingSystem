using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShoppingSystem
{
    internal class Product
    {
        private string name;
        private double price;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }


        protected Product(string name, double price)
        {
            Name = name;
            Price = price;

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
            return $"The Product's name is {name}, and it costs{price}";
        }
    }
}
