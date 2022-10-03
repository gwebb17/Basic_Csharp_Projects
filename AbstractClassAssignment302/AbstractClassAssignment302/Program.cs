using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment302
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee(); //instantiate instance of employee
            worker.firstName = "Sample";  //define prop 1
            worker.lastName = "Student";  //define prop2
            worker.SayName(); //call method on new object


            IQuittable quitty = new Employee();  //make a new IQuittable object based on Employee class
            quitty.Quit();  //call Quit method on quitty

            Console.WriteLine();  

            Console.ReadLine();
        }
    }
}
