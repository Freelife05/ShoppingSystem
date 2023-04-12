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

        public double Time 
        {
            get { return time; }
            set 
            {
                if (time > 0)
                {
                    time = value;
                }
                else
                {
                    throw new ArgumentException("Time must be greater than 0!");
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Price: {Price}\n" +
                $"Time: {Time}";
        }
    }
}
