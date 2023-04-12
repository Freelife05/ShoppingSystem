using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            while (true)
            {
                var splittedInput = Console.ReadLine().Split();
                string command = splittedInput[0];
                List<string> arguments = splittedInput
                    .Skip(1)
                    .ToList();

                try
                {
                    switch (command)
                    {
                        case "Product":
                            Console.WriteLine(controller.Product(arguments));
                            break;
                        case "Service":
                            Console.WriteLine(controller.Service(arguments));
                            break;
                        case "Checkout":
                            Console.WriteLine(controller.Checkout(arguments));
                            break;
                        case "Info":
                            Console.WriteLine(controller.Info(arguments));
                            break;
                        case "End":
                            Console.WriteLine(controller.End());
                            break;
                        default:
                            Console.WriteLine("Invalid command");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
 