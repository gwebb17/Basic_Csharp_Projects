using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment318
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> worker = new Employee<string>();
            worker.things.Add("something");

            Employee<int> worker2 = new Employee<int>();
            worker2.things.Add(32);

            Console.WriteLine(worker);

            Console.ReadLine();
        }
    }
}
