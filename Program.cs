

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            Database db = new Database();
            Bed bed = new Bed();

            db.Open();



            bool mainLoop = true;
            while (mainLoop)
            {

                print.header();

                print.list("1", "add or change size of bed");
                print.list("2", "calculate plant spacing");
                print.list("3", "view plant database");
                print.list("Q", "quit program");

                string nav = print.read().ToLower();

                if (nav == "1")
                {
                    bed.Set();
                }
                else if (nav == "2")
                {
                    db.CalculateSpacing(bed);
                    Console.ReadLine();
                }
                else if (nav == "3")
                {
                    db.ListAll();
                    print.hold();
                    // Console.ReadLine();
                }
                else if (nav == "q")
                {
                    print.line("Goodbye!");
                    mainLoop = false;
                    db.Close();
                }
            }
        }
    }


}