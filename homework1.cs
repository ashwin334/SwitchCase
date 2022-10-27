using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class homework1
    {
        static void Main(string[] args)
        {
            {
                int result = 0;
                Console.WriteLine("enter the first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter symbol(+,-,*,%,/):");

                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(+result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(+result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine(+result);
                        break;
                    case "%":
                        result = num1 % num2;
                        Console.WriteLine(+result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine(+result);
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
        }

    }
}