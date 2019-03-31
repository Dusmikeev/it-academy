using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Program:Employee
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine(internalAnswerToAllQuestions);       //internal is can be accessesed by anyone inside assembly it was declared in
            Console.WriteLine(publicAnswerToAllQuestions);         //public can be accessesed anywhere where assembly is referenced
            Console.WriteLine(privateProtectedAnswerToAllQuestions);         //private protected can be accessesed only in assembly it was declared by inheriting from base class
            Console.WriteLine(protectedAnswerToAllQuestions);         //protected can be accessesed in any assembly by inheriting from base class
            Console.WriteLine(employee.protectedInternalAnswerToAllQuestions); // can be accessed anywhere in assembly it was declared else it needs to be inherited from base class, also requires an instace of class

            Console.Read();
        }
    }
}
