using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a {12345678} very nice {mistakes} test string for my homework {claswork}";
            string[] arrayString = inputString.Split(' ');

            int SymbolsCount(string[] array)
            {
                int count = 0;
                foreach (string word in array)
                {
                    foreach (char letter in word)
                    {
                        count++;
                    }
                }
                return count;
            }

            Console.WriteLine(SymbolsCount(arrayString));
            Console.Read();
            
        }
    }
}
