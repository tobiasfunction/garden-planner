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

            int bedWidth = 0;
            int bedLength = 0;
            int bedSqIn = 0;

            BedArea area = new BedArea();

            SQLiteConnection con = new SQLiteConnection(@"Data Source = /home/tob/Documents/Academy/Code/Git/dbs/gardenbox.sqlite");
            // con.Open();

            bool mainLoop = true;
            while (mainLoop)
            {
                // @MainMenu
                Console.WriteLine("Select an option:\n 1) add size of bed\n 2) calculate plant spacing\n 3) view plant database \n Q) quit program");

                string nav = Console.ReadLine().ToUpper();

                if (nav == "1")
                {
                    bedSqIn = area.Get();
                }
                else if (nav == "2")
                {
                    // Calculate plant spacing
                }
                else if (nav == "3")
                {
                    // View plant database
                }
                else if (nav == "Q")
                {
                    mainLoop = false;
                }


            }
            // con.Close();
        }
    }

    class BedArea
    {
        public int Get()
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
            return 20; //placeholder to stop build error
        }

    }

    // class PlantDatabase
    // {
    //     public void View()
    //     {
    //         cmd = new SQLiteCommand("SELECT Id, Name FROM Plants", con);
    //         reader = cmd.ExecuteReader();
    //         if (reader.HasRows)
    //         {
    //             while (reader.Read())
    //             {
    //                 Console.WriteLine($" {reader["Id"]}) {reader["Name"]}");
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("Not found.");
    //         }

    //     }
    // }
}