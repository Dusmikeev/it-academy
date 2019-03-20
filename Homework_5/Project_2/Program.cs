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
            int arraySize = 5;  //resizable array
            int finalNumber;
            int finalNumberIndex;
            int[] userInput = new int[arraySize];

            Console.WriteLine($"Please type {arraySize - 1} numbers in console");

            for (int i = 0; i < arraySize-1; i++)
            {
                userInput[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int number in userInput)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Please type one more array number");
            finalNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please type index for this number. It should be between 0 and {arraySize - 1}");
            finalNumberIndex = Convert.ToInt32(Console.ReadLine());
            
            for (int i = arraySize-1; i>finalNumberIndex; i--)      //Moving numbers to the right from the end of the array one by one
            {
                userInput[i] = userInput[i-1];
                Console.WriteLine(i);
            }

            userInput[finalNumberIndex] = finalNumber;

            foreach(int number in userInput)
            {
                Console.Write(number + " ");
            }

            Console.Read();
        }
    }
}
