using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment292
{
    public class Person    //parent class definition
    {
        public string FirstName { get; set; }  //defining which props it has
        public string LastName { get; set; }

        public void SayName() //method this class contains
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //displays full name
        }
    }
}
