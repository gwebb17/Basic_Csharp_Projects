using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some message");
            }
            finally
            {
                Console.ReadLine();
            }

            



            Console.ReadLine();

        }
    }

