using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            AddOrSubtract();
        }

        private static void AddOrSubtract()
        {
            int number1;
            int number2;
            int numberResult;
            int userResult;
            string userOperator;
            string plusSign = "+";
            
            Console.WriteLine("Please enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter prefered operator: (-) for subtraction, (+) for addition");
            userOperator = Console.ReadLine();
            Console.WriteLine("Please enter estimated result of this operation");
            userResult = Convert.ToInt32(Console.ReadLine());

            if (userOperator == plusSign)
            {
                numberResult = number1 + number2;
            }
            else
            {
                numberResult = number1 - number2;
            }

            if (userResult == numberResult)
            {
                Console.WriteLine("Good job! Your answer is correct");
            }   
            else if(userResult >numberResult)
            {
                Console.WriteLine("I am sorry, but your answer is bigger than expected");
            }
            else if (userResult < numberResult)
            {
                Console.WriteLine("I am sorry, but your answer is smaller than expected");
            }
            Console.ReadLine();
        }
    }
}
