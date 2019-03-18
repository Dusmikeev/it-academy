using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] reversedArray=new int[array.Length];

            for (int i=array.Length-1, j =0; i >= 0; i--,j++)
            {
                reversedArray[j]=array[i];
            }
            for(int i =0; i<array.Length; i++)
            {
                array[i] = reversedArray[i];   
            }
            foreach (int number in array)
            {   
                Console.Write(number + " ");
            }

            Console.Read();
        }
    }
}
