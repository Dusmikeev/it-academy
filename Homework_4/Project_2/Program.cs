using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput = Convert.ToChar(Console.ReadLine());
            switch (userInput)
            {
                case 'W':
                    Console.WriteLine("Move forward");
                    break;
                case 'S':
                    Console.WriteLine("Move back");
                    break;
                case 'A':
                    Console.WriteLine("Move left");
                    break;
                case 'D':
                    Console.WriteLine("Move right");
                    break;
                default:
                    Console.WriteLine("No proper movement keys were pressed");
                    break;
            }
            Console.Read();
        }
    }
}
