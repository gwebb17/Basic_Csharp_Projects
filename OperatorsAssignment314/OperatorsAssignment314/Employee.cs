using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment314
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //INSTEAD of method name we use keyword 'operator' followed by type of operator in method definitions. These are automatically inherited by objects
        //of this class so thats why we don't need to name them when calling in program.cs (i think)

        public static bool operator == (Employee a, Employee b)  //needs to be static i think, bool because our results are either TRUE or NOT TRUE
        {
            return (a.Id == b.Id);

        }

        public static bool operator != (Employee a, Employee b)   //method2 correlating to opposite case (!=) we need both == and != method present for comparison operator overloading
        {
            return (a.Id != b.Id);
        }
    }
}
