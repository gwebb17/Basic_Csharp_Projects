using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment285
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------Method1 void class access---------------------

            Classy classyObject = new Classy();  //create new object of class

            Console.WriteLine("Please enter a number:");
            int answer = Convert.ToInt32(Console.ReadLine());  //save answer as var
          

            classyObject.Method1(answer);  //call method on object

            //----------------------------Method2 static class access-----------------

            

            Console.WriteLine("enter a number");
            int answer2 = Convert.ToInt32(Console.ReadLine());

            classyObject.Method1(out answer2, answer);





            Console.ReadLine();

        }
    }
}
