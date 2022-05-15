

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

                print.line("  <g>1.</> add or change size of bed");
                print.line("  <g>2.</> calculate plant spacing");
                print.line("  <g>3.</> view plant database");
                print.line("  <g>Q.</> quit program");

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