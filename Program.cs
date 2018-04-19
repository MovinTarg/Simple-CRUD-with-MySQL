using System;
using System.Collections.Generic;
using DbConnection;

namespace Simple_CRUD_with_MySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            DisplayAllUsers();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            nextAction();
        }
        static public void DisplayAllUsers()
        {
            List<Dictionary<string, object>> query = DbConnector.Query("SELECT * FROM Users;");
            foreach(var entry in query)
            {
               foreach(var item in entry)
               {
                   Console.WriteLine(item.Key + " - " + item.Value);
               }
            }
        }
        static public void nextAction()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Type '1' to create a new user.");
            Console.WriteLine("Type '2' to update a user.");
            Console.WriteLine("Type '3' to delete a user.");
            string InputLine = Console.ReadLine();
            switch (InputLine) {
                case "1":
                    Console.WriteLine("Time to create a new user!");
                    promptNewUser();
                    break;
                case "2":
                    Console.WriteLine("Time to update a user!");
                    promptUpdateUser();
                    break;
                case "3":
                    Console.WriteLine("Time to delete a user!");
                    promptDeleteUser();
                    break;
                default:
                    Console.WriteLine("Goodbye");
                    break;
            }
        }
        static public void promptNewUser(){
            Console.WriteLine("\nEnter first name:");
            string first_name = Console.ReadLine();
            Console.WriteLine("\nEnter last name:");
            string last_name = Console.ReadLine();
            Console.WriteLine("\nEnter favorite number:");
            int favorite_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter favorite color:");
            string favorite_color = Console.ReadLine();
            Console.WriteLine("\nEnter favorite language:");
            string favorite_language = Console.ReadLine();
            Console.WriteLine("\nEnter favorite pizza:");
            string favorite_pizza = Console.ReadLine();
            createNewUser(first_name, last_name, favorite_number, favorite_color, favorite_language, favorite_pizza);
        }
        static public void createNewUser(string fn, string ln, int num, string fc, string fl, string fp)
        {   
            string query = $"INSERT INTO Users (first_name, last_name, favorite_number, favorite_color, favorite_language, favorite_pizza) VALUES('{fn}', '{ln}', '{num}', '{fc}', '{fl}', '{fp}');";
            //Console.WriteLine(query);
            DbConnector.Execute(query);
            DisplayAllUsers();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Goodbye");
        }
        static public void promptUpdateUser(){
            Console.WriteLine("\nType the ID# of the user you would like to update!");
            string userID = Console.ReadLine();
            Console.WriteLine("\nEnter first name:");
            string first_name = Console.ReadLine();
            Console.WriteLine("\nEnter last name:");
            string last_name = Console.ReadLine();
            Console.WriteLine("\nEnter favorite number:");
            int favorite_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter favorite color:");
            string favorite_color = Console.ReadLine();
            Console.WriteLine("\nEnter favorite language:");
            string favorite_language = Console.ReadLine();
            Console.WriteLine("\nEnter favorite pizza:");
            string favorite_pizza = Console.ReadLine();
            updateUser(first_name, last_name, favorite_number, favorite_color, favorite_language, favorite_pizza, userID);
        }
        static public void updateUser(string fn, string ln, int num, string fc, string fl, string fp, string userID)
        {   
            string query = $"UPDATE Users SET first_name = '{fn}', last_name = '{ln}', favorite_number = '{num}', favorite_color = '{fc}', favorite_language = '{fl}', favorite_pizza = '{fp}' WHERE id = '{userID}';";
            DbConnector.Execute(query);
            DisplayAllUsers();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Goodbye");
        }
        static public void promptDeleteUser(){
            Console.WriteLine("\nType the ID# of the user you would like to delete!");
            string userID = Console.ReadLine();
            deleteUser(userID);
        }
        static public void deleteUser(string userID)
        {   
            string query = $"DELETE FROM Users WHERE id = '{userID}';";
            DbConnector.Execute(query);
            DisplayAllUsers();
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Goodbye");
        }
    }
}
