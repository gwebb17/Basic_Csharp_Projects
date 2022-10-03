using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment302
{
    public abstract class Person   //make abstract class to be inherited from
    {
        public string firstName { get; set; } //properties of class
        public string lastName { get; set; }

        public virtual void SayName()  //virtual method that other classes must contain when inheriting
        {
            Console.WriteLine(firstName + " " + lastName);  //what method does
        }
        
    }

    
    
}
