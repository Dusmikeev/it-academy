using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a {12345678} very nice {mistakes} test string for my homework {claswork}";
            string outputString = string.Empty;
            int maximumWordLength = 0;
            StringBuilder sb = new StringBuilder();
            string[] testArray = inputString.Split(' ');
            string[] newArray = new string[testArray.Length];

            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i].Length > maximumWordLength)
                {
                    maximumWordLength = testArray[i].Length;
                }
            }

            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i].Length != maximumWordLength)
                {
                    newArray[i] = testArray[i];
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

            outputString = ArrayToString(newArray);
            Console.WriteLine(outputString);
            Console.Read();

        }
    }
}
