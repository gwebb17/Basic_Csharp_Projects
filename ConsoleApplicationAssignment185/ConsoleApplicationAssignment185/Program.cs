using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment185
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: "); //Asks user for input
            string x = Console.ReadLine();  //saves input as string var
            int x1 = Convert.ToInt32(x);  //converts input to number
            int x2 = x1 * 50;  //multiples number by 50
            Console.WriteLine(x2);  //prints multiplied number to screen


            Console.WriteLine("Enter another number: ");
            string b = Console.ReadLine();
            int b1 = Convert.ToInt32(b);
            int b2 = b1 + 25;  //adds converted number that user inputted similar to above example to 25
            Console.WriteLine(b2);


            Console.WriteLine("Enter yet another number: ");
            string c = Console.ReadLine();
            double c1 = Convert.ToDouble(c);  //using doubles for decimal #
            double c2 = c1 / 12.5;
            Console.WriteLine(c2);

            Console.WriteLine("Enter another number: ");
            string d = Console.ReadLine();
            int d1 = Convert.ToInt32(d); //using doubles for decimal #
            bool d2 = d1 > 50;
            Console.WriteLine(d2);

            Console.WriteLine("You know the drill: ");
            string e = Console.ReadLine();
            double e1 = Convert.ToDouble(e); //using modulus with doubles to get remainder of our input number divided by 7
            double e2 = e1 % 7;
            Console.WriteLine(e2);

            Console.ReadLine(); //keeps output terminal running until user closes it
        }
    }
}
