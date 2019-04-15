using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a short poem with each word separated by ;");
            string userPoem = Console.ReadLine();

            string[] poemArray = userPoem.Split(';');

            foreach (string word in poemArray)
            {
                Console.WriteLine(word.Replace('o','a'));
            }
            Console.Read();
        }
    }
}
