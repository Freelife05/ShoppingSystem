using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShoppingSystem
{
    abstract class Product
    {
        private string name;
        private double price;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException(String.Format("Name should be between 3 and 30 characters!"));
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(String.Format("Price should be 0 or positive!"));
                }
                else
                {
                    this.price = value;
                }
            }
        }


        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format( $"The Product's name is {name}, and it costs{price}.");
        }
    }
}
