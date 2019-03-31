using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;


namespace AssemblyTwo
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Program employee = new Program();

            Console.WriteLine(publicAnswerToAllQuestions);
            Console.WriteLine(protectedAnswerToAllQuestions);
            Console.WriteLine(employee.protectedInternalAnswerToAllQuestions);

            Console.Read();
        }
    }
}
