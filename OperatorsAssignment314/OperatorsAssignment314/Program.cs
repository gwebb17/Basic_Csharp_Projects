using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment314
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();  //instantiate class object
            a.Id = 1;
            a.FirstName = "Reggie";
            a.LastName = "Reginold";

            Employee b = new Employee(); //instantiate class object #2 for comparison
            b.Id = 2;
            b.FirstName = "Paul";
            b.LastName = "Wall";

            //uneccessary array assignment keeping just in case proves useful somewhere
            //int[] workerArray = new int[1];  //create an array to hold values for ID props
            //workerArray[0] = a.Id;  //Employee a
            //workerArray[1] = b.Id;  //Employee b

            //Console.WriteLine(workerArray);

            Console.WriteLine(a.Id == b.Id);  //now run 'method' (==) and since == has been redefined in Employee.cs its action will be applied to program when using == or !=



            Console.ReadLine();


        }
    }
}
