using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your language");
            Console.WriteLine("10.English");
            Console.WriteLine("20.Hindi");
            Console.WriteLine("30.Marathi");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 10:
                    Console.WriteLine("You have selected English");
                    break; //come out from switch 
                case 20:
                    Console.WriteLine("You have selected Hindi");
                    break;
                case 30:
                    Console.WriteLine("You have selected Marathi");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }
    }
}
