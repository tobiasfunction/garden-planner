﻿using System;
using System.Data.SQLite;

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            Bed bed = new Bed();

            db.Open();

            bool mainLoop = true;
            while (mainLoop)
            {
                // MainMenu
                Console.WriteLine("Select an option:\n 1) add or change size of bed\n 2) calculate plant spacing\n 3) view plant database \n Q) quit program");

                string nav = Console.ReadLine().ToUpper();

                if (nav == "1")
                {
                    bed.Set();
                }
                else if (nav == "2")
                {
                    //     // Calculate plant spacing

                    //     if (bed.area == 0)
                    //     {
                    //         Console.WriteLine("Please enter bed dimensions first.");
                    //     }
                    //     else
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

                    //         Console.WriteLine("Select a vegetable by ID number:");
                    //         int vegId = int.Parse(Console.ReadLine());

                    //         cmd = new SQLiteCommand($"SELECT Name, PlantSpaceFloor, PlantSpaceCeil, RowSpaceFloor, RowSpaceCeil FROM Plants WHERE Id = {vegId}", con);
                    //         reader = cmd.ExecuteReader();

                    //         if (reader.HasRows)
                    //         {
                    //             while (reader.Read())
                    //             {
                    //                 string plantName = Convert.ToString(reader["Name"]);
                    //                 int plantSpaceFloor = Convert.ToInt32(reader["PlantSpaceFloor"]);
                    //                 int plantSpaceCeil = Convert.ToInt32(reader["PlantSpaceCeil"]);
                    //                 int rowSpaceFloor = Convert.ToInt32(reader["RowSpaceFloor"]);
                    //                 int rowSpaceCeil = Convert.ToInt32(reader["RowSpaceCeil"]);
                    //                 Console.WriteLine("\nPlant Name: " + plantName);
                    //                 Console.WriteLine($"Plant spacing: {plantSpaceFloor}\" - {plantSpaceCeil}\"");
                    //                 Console.WriteLine($"Row spacing: {rowSpaceFloor}\" - {rowSpaceCeil}\"");
                    //                 Console.WriteLine($"Bed Area: {bed.area} sq. ft.");
                    //                 Console.WriteLine();

                    //                 if (bed.width != 0 && bed.length != 0)
                    //                 {
                    //                     int minRows = bed.width * 12 / rowSpaceCeil;
                    //                     int minPerRow = bed.length * 12 / plantSpaceCeil;
                    //                     int minByRow = minRows * minPerRow;
                    //                     int minByAvg = (bed.area * 144) / (plantSpaceCeil * rowSpaceCeil);

                    //                     Console.WriteLine($"minRows: {minRows} = {bed.width} * 12 / {rowSpaceCeil};");
                    //                     Console.WriteLine($"minPerRow: {minPerRow} = {bed.length} * 12 / {plantSpaceCeil};");
                    //                     Console.WriteLine($"minByRow: {minByRow} = {minRows} * {minPerRow};");
                    //                     Console.WriteLine($"minByAvg: {minByAvg} = ({bed.area} * 144) / ({plantSpaceCeil} * {rowSpaceCeil});");

                    //                     Console.WriteLine();

                    //                     int maxRows = bed.width * 12 / rowSpaceFloor;
                    //                     int maxPerRow = bed.length * 12 / plantSpaceFloor;
                    //                     int maxByRow = maxRows * maxPerRow;
                    //                     int maxByAvg = (bed.area * 144) / (plantSpaceFloor * rowSpaceFloor);

                    //                     Console.WriteLine($"maxRows: {maxRows} = {bed.width} * 12 / {rowSpaceFloor};");
                    //                     Console.WriteLine($"maxPerRow: {maxPerRow} = {bed.length} * 12 / {plantSpaceFloor};");
                    //                     Console.WriteLine($"maxByRow: {maxByRow} = {maxRows} * {maxPerRow};");
                    //                     Console.WriteLine($"maxByAvg: {maxByAvg} = ({bed.width} * {bed.length} * 144) / ({plantSpaceFloor} * {rowSpaceFloor});");
                    //                 }
                    //                 else
                    //                 {
                    //                     int minByAvg = (bed.area * 144) / (plantSpaceCeil * rowSpaceCeil);
                    //                     int maxByAvg = (bed.area * 144) / (plantSpaceFloor * rowSpaceFloor);

                    //                     Console.WriteLine($"minByAvg: {minByAvg} = ({bed.area} * 144) / ({plantSpaceCeil} * {rowSpaceCeil});");
                    //                     Console.WriteLine($"maxByAvg: {maxByAvg} = ({bed.area} * 144) / ({plantSpaceFloor} * {rowSpaceFloor});");

                    //                 }
                    //             }
                    //         }
                    //         else
                    //         {
                    //             Console.WriteLine("Not found.");
                    //         }
                    //     }
                    //     Console.ReadLine();
                }
                else if (nav == "3")
                {
                    db.ListAll();
                }
                else if (nav == "Q")
                {
                    mainLoop = false;
                    db.Close();
                }
            }
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
                Console.WriteLine("What is the width of your box, in feet?");
                width = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of your box, in feet?");
                length = int.Parse(Console.ReadLine());
                area = length * width;
            }
            else if (nav == "2")
            {
                // Calculate using square feet
                Console.WriteLine("What is the area of your box, in square feet?");
                area = int.Parse(Console.ReadLine());
                width = 0;
                length = 0;
                Console.WriteLine(area);
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

    class Database
    {
        public SQLiteConnection con = new SQLiteConnection(@"Data Source = /home/tob/Documents/Academy/Code/Git/dbs/gardenbox.sqlite");
        public SQLiteCommand cmd;
        public SQLiteDataReader reader;

        public void Open()
        {
            con.Open();
        }
        public void Close()
        {
            con.Close();
        }

        public void ListAll()
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
            Console.ReadLine();
        }

    }
}