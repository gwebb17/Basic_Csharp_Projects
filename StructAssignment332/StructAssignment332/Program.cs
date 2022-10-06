using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment332
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numberOne = new Number(); //instantiate
            numberOne.amount = 10.1m;
            Console.WriteLine(numberOne.amount);
            Console.ReadLine();
        }
    }
}
