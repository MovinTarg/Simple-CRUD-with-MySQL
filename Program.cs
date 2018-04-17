using System;
using System.Collections.Generic;
using DbConnection;

namespace Simple_CRUD_with_MySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DisplayAllUsers();
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
        static public void createNewUser(string fn, string ln, int num, string fc, string fl, string fp)
        {   
            string query = $"INSERT INTO Users (first_name, last_name, favorite_number, favorite_color, favorite_language, favorite_pizza) VALUES('{fn}', '{ln}', '{num}', '{fc}', '{fl}', '{fp}');";
            //Console.WriteLine(query);
            DbConnector.Execute(query);
            DisplayAllUsers();
        }
    }
}
