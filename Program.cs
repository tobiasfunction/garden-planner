using System;
using System.Data.SQLite;

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello ".PadRight(20, '*'));
            System.Console.WriteLine("hello hello ".PadRight(20, '*'));


            SQLiteCommand cmd;
            SQLiteDataReader reader;

            int bedWidth = 0;
            int bedLength = 0;
            int bedArea = 0;

            SQLiteConnection conn = new SQLiteConnection(@"Data Source = /home/tob/Documents/Academy/Code/Git/dbs/gardenbox.sqlite");
            conn.Open();
            bool going = true;

            while (going)
            {
                Console.WriteLine("Calculate using:\n 1) width and length\n 2) square feet");
                string nav = Console.ReadLine();

                if (nav == "1")
                {
                    // Calculate using length and width

                }
                else if (nav == "2")
                {
                    // Calculate using square feet
                }
                else
                {
                    // Invalid input
                }

                System.Console.WriteLine("What vegetable are you planting?");

                cmd = new SQLiteCommand("SELECT Id, Name FROM Plants", con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($" {reader["Id"]}) {reader["Name"]}");
                    }
                }
                else
                {
                    Console.WriteLine("Not found.");
                }
                Console.ReadLine();
                going = false;
            }

            conn.Close();
        }
    }
}