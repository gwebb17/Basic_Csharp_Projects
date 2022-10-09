using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment385
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Bill");
            const int personID = 385;  //create constant
            var personName = "Bill";

            Console.WriteLine(emp1.LastName); //now that employee class has been given default value for LastName 
            //when that param isn't provided it will be filled in with default "Johnson" LastName
            Console.WriteLine(emp1.FirstName);

            Console.ReadLine();
        }
    }
}
