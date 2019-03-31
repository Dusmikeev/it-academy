using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssemblyOne
{
    public class Employee
    {
        public const string publicAnswerToAllQuestions = "public - 42";

        protected const string protectedAnswerToAllQuestions = "protected - 42";

        internal const string internalAnswerToAllQuestions = "internal - 42";

        protected internal string protectedInternalAnswerToAllQuestions = "protected internal - 42";

        private const string privateAnswerToAllQuestions = "private - 42";      //can be only accessesed here in this type

        private protected const string privateProtectedAnswerToAllQuestions = "private protected - 42";
    }
}
