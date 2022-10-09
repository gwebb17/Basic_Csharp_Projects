using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment390
{
    public class YearException : Exception
    {
        public int Age { get; } //age is the var we need to access from program (we need to 'get' that var)

        public YearException() //basic constructor?
        {

        }

        public YearException(string message)
            : base(message)
        {

        }

        public YearException(string message, Exception inner)
            : base(message, inner) { }

        public YearException(string message, int age)
            : this(message)
        {
            Age = age;

        }
    }
}
