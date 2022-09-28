using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment251
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------STEP 1-------------------------------------------
            string[] stringyArray = new string[5];  //create new string array object
            stringyArray[0] = "Oumuamua";
            stringyArray[1] = "Oort cloud";
            stringyArray[2] = "Cosmic Microwave Background";
            stringyArray[3] = "Pillars of Creation";
            stringyArray[4] = "Nebulae";

            Console.WriteLine("Please enter various words");
            string answer = Console.ReadLine(); //save response as var


            for (int i = 0; i < stringyArray.Length; i++) //iterate through each item in array
            {
                stringyArray[i] += " " + answer; //redefine var adding a space and user input to end
                Console.WriteLine(stringyArray[i]); //display newly concatenated string array
            }



            //-------------------------------STEP 2--------------------------------------------
            int[] intArray = { 3, 5, 7, 17, 4 }; //declare array with fixed amount of values


            //**HERE IS INFINITE LOOP
            //while (intArray.Length < 7) make statement that will always be true so loop is infinite
            //{
            //    Console.WriteLine("Print this forever");
            //}

            //HERE IS INFINITE LOOP FIX
            for (int j = 0; j < intArray.Length; j++)   //instead of using while based on an always true condition;
                                                        //we use logic representing total length of array (which has finite endpoint)
            {
                Console.WriteLine(intArray[j]);
            }




            //------------------------------STEP 3----------------------------------------------
            int[] intArrayA = { 4, 5, 88, 129 }; //declare array

            for (int h = 0; h < intArrayA.Length; h++) //while our iterations are less than array length, continue
            {
                Console.WriteLine(intArrayA[h]);
            }

            for (int e = 0; e <= intArrayA.Length - 2; e++) //if e is less than or equal to array length-2, continue
            {
                Console.WriteLine(intArrayA[e]); //this logic ends loop before completing full array length
            }


            //------------------------------STEP 4----------------------------------------------
            List<string> stringyList = new List<string>(); //declare list with unknown length
            stringyList.Add("Rome");
            stringyList.Add("Munich");
            stringyList.Add("Warsaw");
            stringyList.Add("Cologne");
            stringyList.Add("Berlin");
            stringyList.Add("Prague");

            Console.WriteLine("Name a well known European city");
            string step4Answer = Console.ReadLine();  //save answer as var

            foreach (string answers in stringyList) //go through each string in the List and give a course of action
                                                    //to take if the string matches user input
            {
                if (step4Answer == "Rome")
                {
                    Console.WriteLine("Index value: 0");
                }
                else if (step4Answer == "Munich")
                {
                    Console.WriteLine("Index value: 1");
                }
                else if (step4Answer == "Warsaw")
                {
                    Console.WriteLine("Index value: 2");
                }
                else if (step4Answer == "Cologne")
                {
                    Console.WriteLine("Berlin");
                }
                else if (step4Answer == "Berlin")
                {
                    Console.WriteLine("Index value: 3");
                }
                else if (step4Answer == "Prague")
                {
                    Console.WriteLine("Index value: 4");
                }
                else
                {
                    Console.WriteLine("Sorry, your answer isn't on the list"); //action to take if answer/input doesn't match any list items
                }

                //for (int l = 0; l < stringyList.Count; l++) **this is potential alternate way of looping in case above way doesn't meet requirements**
                //    if (l == step4Answer)                     **would require conversion of strings to ints in order to use "l" iterations
                //    {

                //    }
            }


            //------------------------------STEP 5----------------------------------------------
            List<string> step5List = new List<string>(); //initialize list with unknown value amounts
            step5List.Add("Pluto");
            step5List.Add("Mars");
            step5List.Add("Mercury");
            step5List.Add("Venus");
            step5List.Add("Venus");
            step5List.Add("Mars");

            Console.WriteLine("Enter a planet name to see if it's on the list, yes Pluto gets to be a planet today");
            string step5Answer = Console.ReadLine(); //store answer as var

            for (int i = 0; i < step5List.Count; i++)  //do we need a for (i = 0) loop inside this to return indice ?
            {
                if (step5List[i] == step5Answer)
                {
                    Console.WriteLine("Match found at: " + i);
                }
            }

            if (!step5List.Contains(step5Answer))  //this is how we say if list DOES NOT contain
            {
                Console.WriteLine("Match not found for item " + step5Answer);
            }


            //------------------------------STEP 6----------------------------------------------
            List<string> step6List = new List<string>(); //initialize list with two duplicate values
            step6List.Add("Reticulated Python");
            step6List.Add("Kingsnake");
            step6List.Add("Indian Cobra");
            step6List.Add("Colombian Red-Tail Boa");
            step6List.Add("Reticulated Python");
            step6List.Add("Carpet Python");

            foreach (string snakes in step6List) //create foreach loop iterating through each item in list
            {
                if (step6List[0].Contains(snakes))
                {
                    Console.WriteLine(snakes + " - This is a duplicate");
                }
                else if (step6List[4].Contains(snakes))
                {
                    Console.WriteLine(snakes + " This is a unique value");
                }
                else if (step6List[1].Contains(snakes))
                {
                    Console.WriteLine(snakes + " - This is a unique value");
                }
                else if (step6List[2].Contains(snakes))
                {
                    Console.WriteLine(snakes + " - This is a unique value");
                }
                else if (step6List[3].Contains(snakes))
                {
                    Console.WriteLine(snakes + " - This is a unique value");
                }
                else if (step6List[5].Contains(snakes))
                {
                    Console.WriteLine(snakes + " - This is a unique value");
                }
            }


            Console.ReadLine();

        }
    }
}
