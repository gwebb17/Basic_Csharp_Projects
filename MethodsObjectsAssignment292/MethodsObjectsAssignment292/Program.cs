using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment292
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee() { FirstName = "Sample", LastName = "Student" };  //instantiate and give values in one line
            worker.SayName(); //call method from Person class on newly defined object 'worker'

            Console.ReadLine();
        }
    }
}
