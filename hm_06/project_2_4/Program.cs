using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This is a {12345678} very nice {mistakes} test string for my homework {claswork}";
            StringBuilder sb = new StringBuilder();
            string[] testArray = inputString.Split(' ');

            void SortingArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    string temp;

                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i].Length < array[j].Length)
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
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

            SortingArray(testArray);
            string newString = ArrayToString(testArray);

            Console.WriteLine(newString);
            Console.Read();
        }

        
    }
}
