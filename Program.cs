using System;
using System.Data.SQLite;


namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source = /home/tob/Documents/Academy/Code/Git/dbs/gardenbox.sqlite");
            con.Open();
            con.Close();
        }
    }
}