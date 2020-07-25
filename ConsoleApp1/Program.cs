using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool backTop = true;

            while (backTop)

            {

                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Operator: ");
                string op = Console.ReadLine();

                Console.Write("Enter a number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());



                if (op == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (op == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (op == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
                else if (op == "*")
                {
                    Console.WriteLine("The result is: " + num1 * num2);
                }
                else
                {
                    Console.WriteLine("Invalid Operator Try Again");
                }

                Console.WriteLine();

            }

            

            Console.ReadLine();

        }

    }
}
