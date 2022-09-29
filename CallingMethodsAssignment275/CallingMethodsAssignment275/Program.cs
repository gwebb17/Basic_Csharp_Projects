using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment275
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number to operate on");
            int x = Convert.ToInt32(Console.ReadLine());   //stores user input as int var

            
            int result = Classy.Method1(x);   //create var that is the outcome of Method1's operation on x
            Console.WriteLine(result);   //return that outcome var to console

            int result2 = Classy.Method2(x);   //repeat
            Console.WriteLine(result2);

            int result3 = Classy.Method3(x);  //repeat
            Console.WriteLine(result3);


            Console.ReadLine();

            

            
        }
    }
}
