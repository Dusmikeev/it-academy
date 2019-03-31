using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = { 32, 'A', "Hello" };
            int additionalNumber = 10;
            string additionalText = ", guys!";

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }

            int firstArrayElement = (int)array[0];
            string lastArrayElement = (string)array[2];

            firstArrayElement += additionalNumber;
            lastArrayElement += additionalText;

            array[0] = firstArrayElement;
            array[2] = lastArrayElement;

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }

            Console.Read();
        }
    }
}
