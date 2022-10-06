using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment338
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> newList = new List<Employee>()    //instantiate List
            {
                new Employee { ID = 1, FirstName = "Fred", LastName = "Jones" },  //give list 10 values
                new Employee { ID = 2, FirstName = "Ted", LastName = "Jones" },
                new Employee { ID = 3, FirstName = "Joe", LastName = "Bones" },
                new Employee { ID = 4, FirstName = "Olivia", LastName = "Green" },
                new Employee { ID = 5, FirstName = "Scarlett", LastName = "O'harra" },
                new Employee { ID = 6, FirstName = "Ron", LastName = "Swanson" },
                new Employee { ID = 7, FirstName = "Hester", LastName = "Prynne" },
                new Employee { ID = 8, FirstName = "Bram", LastName = "Stoker" },
                new Employee { ID = 9, FirstName = "Joe", LastName = "Brown" },
                new Employee { ID = 10, FirstName = "Reggie", LastName = "Yellow" }
            };


            foreach (Employee worker in newList)
            {
                List<Employee> loopList = new List<Employee>(); //instantiate new list with loop
                if (worker.FirstName == "Joe")
                {
                    loopList.Add(worker); //add firstname prop to list if it == "Joe"
                    Console.WriteLine(worker.FirstName); //has to be inside if statement to work properly
                }
            }

            List<Employee> lambList2 = newList.Where(y => y.FirstName == "Joe").ToList(); //1st lambda expression with new list (lambList2) to hold matching values
            List<Employee> lambList = newList.Where(x => x.ID > 5).ToList(); //2nd lambda expression with new list (lambList) to hold matching values
            foreach (Employee listWorker in lambList2) //use iterator var listWorker to be our placeholder to reference
            {
                Console.WriteLine(listWorker.FirstName);  //must use foreach to display results properly 
            }
            foreach (Employee listWorkerB in lambList) //use iterator var listWorkerB to be our placeholder to reference
            {
                Console.WriteLine(listWorkerB.ID); //now can use listWorkerB prop ID to display
            }

           




            Console.ReadLine();
            
            


        }
    }
}
