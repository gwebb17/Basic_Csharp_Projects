using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment385
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public Employee(string FirstName) : this(FirstName, "Tom")
        {
            //this.FirstName = FirstName;
            //LastName = "Johnson";
        }

        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

    }

}
