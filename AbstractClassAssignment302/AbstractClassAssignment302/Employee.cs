using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment302
{
    public class Employee : Person, IQuittable  //inherits from Person class
    {
        public override void SayName()  //contains abstract method from parent class 
        {
            base.SayName();
        }
        public void Quit() //calling interface method 
        {
            Console.WriteLine("Someone quit.");  //give method an action
        }

    }        
}
