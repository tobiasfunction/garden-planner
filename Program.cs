

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();
            Database db = new Database();
            Bed bed = new Bed();

            db.Open();

            bool mainLoop = true;
            while (mainLoop)
            {

                print.header();

                print.color("  <g>1.</> add or change size of bed");
                print.color("  <g>2.</> calculate plant spacing");
                print.color("  <g>3.</> view plant database");
                print.color("  <g>Q.</> quit program");

                string nav = print.prompt().ToLower();

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
                    Console.ReadLine();
                }
                else if (nav == "q")
                {
                    mainLoop = false;
                    db.Close();
                }
            }
        }
    }

    
}