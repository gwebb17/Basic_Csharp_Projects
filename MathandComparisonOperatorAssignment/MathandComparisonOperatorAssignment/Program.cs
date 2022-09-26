using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");  //steps 1-2
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            string a = Console.ReadLine();
            double a1 = Convert.ToDouble(a);
            Console.WriteLine("Hours per week: ");
            string b = Console.ReadLine();
            double b1 = Convert.ToDouble(b);

            //steps 3 person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            string c = Console.ReadLine();
            double c1 = Convert.ToDouble(c);
            Console.WriteLine("Hours per week: ");
            string d = Console.ReadLine();
            double d1 = Convert.ToDouble(d);

            //step 4
            Console.WriteLine("Annual salary of Person 1: ");
            double sal1 = a1 * b1;
            double sall1 = sal1 * 52.1429; //multiply by weeks in a year to get salary
            Console.WriteLine(sall1);

            //step 5
            Console.WriteLine("Annual salary of Person 2: ");
            double sal2 = c1 * d1;
            double sall2 = sal2 * 52.1429;
            Console.WriteLine(sall2);

            //step 6
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare1 = Convert.ToBoolean(sall1); //convert to bools so they can be used in according statements
            bool compare2 = Convert.ToBoolean(sall2);
            bool compare3 = sall1 > sall2; //now we can use comparison statement
            Console.WriteLine(compare3);


            Console.ReadLine(); //keep screen open
        }
    }
}
