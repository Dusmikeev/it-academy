using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char letter = 'Z'; letter >= 'A'; letter--)
            {
                Console.Write(letter);
            }
            Console.Read();
        }
    }
}
