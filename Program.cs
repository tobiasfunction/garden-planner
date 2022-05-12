using System;
using System.Data.SQLite;

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteCommand cmd;
            SQLiteDataReader reader;
            BedArea area = new BedArea();

            SQLiteConnection con = new SQLiteConnection(@"Data Source = /home/tob/Documents/Academy/Code/Git/dbs/gardenbox.sqlite");
            con.Open();

            bool mainLoop = true;
            while (mainLoop)
            {
                // @MainMenu
                Console.WriteLine("Select an option:\n 1) add size of bed\n 2) calculate plant spacing\n 3) view plant database \n Q) quit program");

                string nav = Console.ReadLine().ToUpper();

                if (nav == "1")
                {
                    bed.Set();
                }
                else if (nav == "2")
                {
                    // Calculate plant spacing
                }
                else if (nav == "3")
                {
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
                }
                else if (nav == "Q")
                {
                    mainLoop = false;
                }
            }
            con.Close();
        }
    }

    class Bed
    {
        public int width;
        public int length;
        public int area;
        public void Set()
        {
            Console.WriteLine("Calculate using:\n 1) width and length\n 2) square feet\n B) go back to previous menu");
            string nav = Console.ReadLine().ToUpper();

            if (nav == "1")
            {
                // Calculate using length and width
            }
            else if (nav == "2")
            {
                // Calculate using square feet
            }
            else if (nav == "B")
            {
                // Return to previous menu
            }
            else
            {
                // Invalid input
            }
        }
    }
}