using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment285
{
    class Classy
    {
       public void Method1(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);  //how to display result since method doesn't output anything

        }

        public void Method1(out int x, int b = 2)  //create static void method inside class with overloaded parameter b (defult value given)
        {
            x = 5;
            //Console.WriteLine("Enter a number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            int result2 = x * b;  //save result of operation for display
            Console.WriteLine(result2);  //display result of operation
        }


    }
}
