using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment279
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Thingy = new Class1();   //instantiate first class object
            int mainResult1 = class1Thingy.Method1(7);
            Console.WriteLine(mainResult1);



            Class1 class2Thingy = new Class1(); //instantiate second object
            int mainResult2 = class2Thingy.Method2(5.50);
            Console.WriteLine(mainResult2);


            Class1 class3Thingy = new Class1();  //instantiate 3rd class object
            int mainResult3 = class3Thingy.Method2("1");  //pass in string 1 as param to be used
            Console.WriteLine(mainResult3);



            Console.ReadLine();


            
        }
        
    }
}
