using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment285
{
    public static class Classy2  //create class that is static
    {
        public static void Method2(int a, int b = 2)  //create static void method inside class with overloaded parameter b (defult value given)
        {
            int result2 = a * b;  //save result of operation for display
            Console.WriteLine(result2);  //display result of operation
        }
    }
}
