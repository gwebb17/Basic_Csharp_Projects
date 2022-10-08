using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment366
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter a number");
            string answer = Console.ReadLine();
            File.WriteAllText(@"C:\\Users\\Machine\\Documents\\practice_file.txt", answer); //writes user number to specified file

            string path = @"C:\\Users\\Machine\\Documents\\practice_file.txt";
            string readText = File.ReadAllText(path, Encoding.UTF8); //saves contents of specified file to var
            Console.WriteLine(readText);  //prints that var to console.
            Console.ReadLine();
        }
    }
}
