using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2;
            string op;

            try
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator: ");
                op = Console.ReadLine();

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

            
                if (op == "+")
                    Console.WriteLine(num1 + num2);
                else if (op == "-")
                    Console.WriteLine(num1 - num2);
                else if (op == "*")
                    Console.WriteLine(num1 * num2);
                else if (op == "/")
                    Console.WriteLine(num1 / num2);
                else
                    Console.WriteLine("You entered invalid operator!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Error!");
            }
            Console.ReadLine();
        }
        
    }
}
