using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a test string for my homework!";
            string outputString = string.Empty;
            int maximumWordLength = 0;
            int minimumWordLength = 0;
            int maximumWordIndex = 0;
            StringBuilder sb = new StringBuilder();
            string[] testArray = inputString.Split(' ');

            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i].Length > maximumWordLength)
                {
                    maximumWordLength = testArray[i].Length;
                    maximumWordIndex = i;
                }
            }

            minimumWordLength = maximumWordLength;

            for (int i = 0; i < testArray.Length; i++)
            {
                if (minimumWordLength> testArray[i].Length)
                {
                    minimumWordLength = testArray[i].Length;
                }
            }

            for (int i = 0; i < testArray.Length; i++)
            {
                if(testArray[i].Length == minimumWordLength)
                {
                    string tempString = testArray[maximumWordIndex];
                    testArray[maximumWordIndex] = testArray[i];
                    testArray[i] = tempString;
                }
            }
 
            string ArrayToString(string[] array)
            {
                string tempString = string.Empty;

                foreach (string value in array)
                {
                    if (value != null)
                    {
                        sb.Append(value + " ");
                    }
                }

                return tempString = sb.ToString();
            }

            outputString = ArrayToString(testArray);

            Console.WriteLine(outputString);
            Console.Read();

        }
        
    }
    
}
