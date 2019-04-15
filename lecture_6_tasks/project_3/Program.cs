using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] randomNumbers = new int[13];
            int maximumNumber = 0;

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next();
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > maximumNumber)
                {
                    maximumNumber = randomNumbers[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Maximum number is - { maximumNumber}");
            Console.Read();
        }
    }
}
