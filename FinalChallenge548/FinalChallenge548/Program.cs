using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge548
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentListContext())
            {
                Console.WriteLine("Enter new student first name: ");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter new student last name: ");
                string lName = Console.ReadLine();

                var newStudent = new Student { FirstName = fName, LastName = lName };
                db.Students.Add(newStudent);
                db.SaveChanges();

                var query = from i in db.Students orderby i.FirstName select i;

                Console.WriteLine("Current entries in database: ");
                foreach (var thing in query)
                {
                    Console.WriteLine(thing.FirstName + " " + thing.LastName);
                }
                Console.ReadLine();
                 
            }
        }
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        public class StudentListContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }

        
    }
}
