using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats your fav #");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "you guessed it " : "you didn't guess it";
            Console.WriteLine(result);
            //int roomTemperature = 70;
            //Console.WriteLine("whats your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("hi " + name + " what is temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("its exactly room temp");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("its warmer than room temp");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("its colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("something went wront");
            //}
            
            
            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "it is exactly room temp" : "it is not exactly room temp";
            //Console.WriteLine(comparisonResult);
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("its warmer than roomtemp");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("room temp is warmer than current");
            //}
            //else
            //{
            //    Console.WriteLine("it is not exactly room temperature");
            //}
            Console.ReadLine();
        }
    }
}
