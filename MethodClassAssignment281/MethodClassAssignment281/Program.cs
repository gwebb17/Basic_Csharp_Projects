using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment281
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Object = new Class1(); //create new object
            class1Object.Method1(7, 8);  ///WHEN USING VOID METHOD WE JUST CALL METHOD LIKE THIS

            class1Object.Method1(x:1, y:98);  //TO GIVE VALUES FOR PARAMS USE : NOT =
            Console.ReadLine();
        }
    }
}
