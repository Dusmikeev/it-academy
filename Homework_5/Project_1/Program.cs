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
            int arraySize = 5;      //resizable array
            int randomMax = 100;    //resizable ceiling of random max numbers
            Random random = new Random();
            int[] userNumbers = new int[arraySize];
            int[] randomNumbers = new int[arraySize];
            int[] sumNumbers = new int[arraySize];

            Console.WriteLine($"Please type {arraySize} numbers in console");

            for (int i = 0; i < arraySize; i++)
            {
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int number in userNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arraySize; i++)
            {
                randomNumbers[i] = random.Next(0, randomMax);
                Console.Write(randomNumbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arraySize; i++)
            {
                sumNumbers[i] = randomNumbers[i] + userNumbers[i];
                Console.Write(sumNumbers[i] + " ");
            }

            Console.Read();
        }
    }
}
