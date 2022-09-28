using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArraySubmissionAssignment242
{
    class Program
    {
        static void Main()
        {

            //------------------------------------STRING ARRAY--------------------------------------

            string[] stringArray = new string[5];  //setup for string Array
            stringArray[0] = "you selected 0";
            stringArray[1] = "you selected 1";
            stringArray[2] = "you selected 2";
            stringArray[3] = "you selected 3";
            stringArray[4] = "you selected 4";


            Console.WriteLine("Please select one of the indices of the array (0, 1, 2, 3, or 4)");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch(answer)
            {
                case 0:   //switch statement giving a result for each possible selection 
                    Console.WriteLine(stringArray[0]); //will print if 0 is chosen
                    break;
                case 1:
                    Console.WriteLine(stringArray[1]);
                    break;
                case 2:
                    Console.WriteLine(stringArray[2]);
                    break;
                case 3:
                    Console.WriteLine(stringArray[3]);
                    break;
                case 4:
                    Console.WriteLine(stringArray[4]);
                    break;
                default:
                    Console.WriteLine("Did you read the instructions?");
                    break;
            }

            //----------------------------INT ARRAY-------------------------------------

            int[] intArray = new int[5]; //setup for int array
            intArray[0] = 4;
            intArray[1] = 8;
            intArray[2] = 89;
            intArray[3] = 4747;
            intArray[4] = 1;

            Console.WriteLine("Please select one of the indices of the array (0, 1, 2, 3, or 4");
            int answerA = Convert.ToInt32(Console.ReadLine());

            switch(answerA)  //switch statement with specified outcome for each possible selection in above question.
            {
                case 0:
                    Console.WriteLine(intArray[0]);
                    break;
                case 1:
                    Console.WriteLine(intArray[1]);
                    break;
                case 2:
                    Console.WriteLine(intArray[2]);
                    break;
                case 3:
                    Console.WriteLine(intArray[3]);
                    break;
                case 4:
                    Console.WriteLine(intArray[4]);
                    break;
                default:
                    Console.WriteLine("You must not have read instructions again");
                    break;
            }


            //----------------------------LISTS------------------------------------------

            List<string> stringyList = new List<string>();  //setup for string list with 5 values
            stringyList.Add("Hello");
            stringyList.Add("Bounjour");
            stringyList.Add("Zdorovatseeyah");
            stringyList.Add("Hallo");
            stringyList.Add("Buna ziua");

            Console.WriteLine("Please select one of the indices (0, 1, 2, 3, or 4)"); //ask user to select indice
            int answerB = Convert.ToInt32(Console.ReadLine());

            switch(answerB)
            {
                case 0:
                    Console.WriteLine(stringyList[0]);
                    break;
                case 1:
                    Console.WriteLine(stringyList[1]);
                    break;
                case 2:
                    Console.WriteLine(stringyList[2]);
                    break;
                case 3:
                    Console.WriteLine(stringyList[3]);
                    break;
                case 4:
                    Console.WriteLine(stringyList[4]);
                    break;
                default:
                    Console.WriteLine("Still not listening to directions eh?");
                    break; 
            }


            


            Console.ReadLine();
        }
    }
}
