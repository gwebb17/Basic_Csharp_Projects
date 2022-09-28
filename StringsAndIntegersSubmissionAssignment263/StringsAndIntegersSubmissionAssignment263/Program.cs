using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersSubmissionAssignment263
{
    class Program
    {
        static void Main(string[] args)
        {
        
            try    ///LOGIC MUST BE INSIDE TRY CATCH BLOCK OTHERWISE CATCH/FIANLLY AREN'T APPLIED
            {
                List<int> intList = new List<int>(); //instantiate new integer list and add below values to it.
                intList.Add(485);
                intList.Add(2);
                intList.Add(17);
                intList.Add(77);

                Console.WriteLine("please enter a divisor: "); 
                int divisor = Convert.ToInt32(Console.ReadLine()); //save input as int var


                for (int i = 0; i < intList.Count; i++) //basic iteration through above List
                    {
                        int x = intList[i] / divisor; //divide input var by the value of current inidice iteration through List
                        Console.WriteLine(x);         //and save as var x
                    }
            }
            catch (FormatException ex)  //in event of wrong format input by user
            {
                Console.WriteLine("Error: Input string was not in a correct format.", ex.Message);  //return this
            }
            catch (DivideByZeroException ex)  //in event user tries to divide by 0
            {
                Console.WriteLine("Error: Attempted to divide by zero.", ex.Message); //return this
            }
            finally  //return below message everytime code is run regardless of exceptions occuring or not
            {
                Console.WriteLine("This message is to let you know the program has emerged from the try/catch block"); 
            }


            //Error Messages:
            //System.DivideByZeroException: 'Attempted to divide by zero.'
            //System.FormatException: 'Input string was not in a correct format.'

            Console.ReadLine();

        }
    }
}
