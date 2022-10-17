using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using ClassesAndObjectsLibrary265;
using ClassesAndObjectsLibrary265.ClassesAndObjects265;

namespace ClassesAndObjects265
{
    public class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Welcome to the Completely Fictional Hotel and Casino, please enter your name: ");
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();

                }
                Console.ReadLine();
                return;
            }

            bool validAnswer = false;   //set so we can execute a while loop on it
            int bank = 0; //set default value
            while (!validAnswer)  //which is false above so will execute
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //TryParse searches (Console.ReadLine() so answer from line27 for int. sends out bank to be used in line 24
                //validAnswer will equal TRUE if TryParse can find int values in the answer of line27 and send that int to bank line24
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals."); //if validAnswer equals FALSE enter a message 
            }

            Console.WriteLine("Hello {0}. Would you like to play a game?", playerName);
            string answer = Console.ReadLine().ToLower(); //convert answer to lowercase makes it easier to check response below

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")  //if they want to play we create player from them and new game
            {
                Player player = new Player(playerName, bank); //create new player with name and bank props
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\\Users\\Machine\\Documents\\practice_file.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();  //create new game
                game += player; //Add player to the newly created game

                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)  //loop that executes when player is playing and has balance > 0
                {
                    try //try catches are written in order top to bottom of what computer will try. 
                    {
                        game.Play(); //Play defined in TwentyOneGame
                    }
                    catch (FraudException ex) //giving Fraudexception name of "ex" so that it can be passed in below with Update line
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured please contact sytem administrator");
                        Console.ReadLine();
                        UpdateDbWithException(ex);
                        return;
                    }

                }
                game -= player; //if player isn't playing remove player from game
                Console.WriteLine("Thanks for playing"); //triggers after player stops playing and is removed from game
                Console.ReadLine();
            }

        }

            //******FOR SQL METHOD THAT ADDS PARAMETERS AND SHOWS BASIC COMMAND STRUCTURE***************************
            private static void UpdateDbWithException(Exception ex)
            {
                string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=ClassesAndObjects265;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                        (@ExceptionType, @ExceptionMessage, @TimeStamp)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                    command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                    command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                    command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                    command.Parameters["@ExceptionMessage"].Value = ex.Message;
                    command.Parameters["@TimeStamp"].Value = DateTime.Now;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

            }
            private static List<ExceptionEntity> ReadExceptions()
            {
                string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=ClassesAndObjects265;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

                List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())  //loops through each record we return
                    {
                        ExceptionEntity exception = new ExceptionEntity(); //this instantiates one instance of the class ExceptionEntity which is a value for each of the properties
                        exception.Id = Convert.ToInt32(reader["Id"]); //these lines are converting the string values of database table into proper data types that class accepts
                        exception.ExceptionType = reader["ExceptionType"].ToString();
                        exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                        exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                        Exceptions.Add(exception); //Exceptions is our new list on line 122 .Add adds () to that. exception is defined line 133

                    }
                    connection.Close();
                    
                }

                return Exceptions;
           



            }

        }
    }

