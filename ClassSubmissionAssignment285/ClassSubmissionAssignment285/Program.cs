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

            Console.WriteLine("Enter another number");
            int answer2 = Convert.ToInt32(Console.ReadLine());  //ask for input and save as int

            Classy2.Method2(answer2);
      


            Console.ReadLine();

        }
    }
}
