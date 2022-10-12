using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x =2;
            int y =1;
            if (x!=y)
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }

            int a = 4;
            int b = 4;
            if((x>y)||(a>b))
            {
                Console.WriteLine($"{x} is greater than {y} and {a} is greater than {b}");
            }

            string CoffeeorTea;
            string CTType;
            Console.Write("What is your order Coffee or Tea: ");
            CoffeeorTea = Console.ReadLine();
            
            if(CoffeeorTea=="coffee")
            {
                Console.Write(" Americano or Black Coffee: ");
                CTType = Console.ReadLine();
                if(CTType=="americano")
                {
                    Console.WriteLine(" You choose Americano Coffee");
                }
                else if (CTType=="black")
                {
                    Console.WriteLine(" You choose Black Coffee");
                }
                else
                {
                    Console.WriteLine(" Not from the option");
                }
            }
            else if (CoffeeorTea=="tea")
            {
                Console.Write(" Green Tea or Black Tea: ");
                CTType = Console.ReadLine();
                if (CTType == "green")
                {
                    Console.WriteLine(" You choose Green Tea");
                }
                else if (CTType == "black")
                {
                    Console.WriteLine(" You choose Black Tea");
                }
                else
                {
                    Console.WriteLine(" Not from the option");
                }
            }
            else
            {
                Console.WriteLine("Not in the choices");
            }

            Console.ReadLine();
        }
    }
}
