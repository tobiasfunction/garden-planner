using System;
using System.Text.RegularExpressions;

namespace GardenBox
{
    public class Print
    {
        public void header()
        {
            int width = 80;
            string headerTitle = " Veggie Calculator ";
            string ornament = "\u2020.";

            Console.Clear();
            // if (headerTitle.Length % 2 != 0)
            // {
            //     headerTitle += " ";
            // }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("." + string.Concat(Enumerable.Repeat(ornament, (width / 2))));
            Console.Write("." + string.Concat(Enumerable.Repeat(ornament, ((width - headerTitle.Length) / 4))));
            Console.ResetColor();
            Console.Write(headerTitle);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("." + string.Concat(Enumerable.Repeat(ornament, ((width - headerTitle.Length) / 4))));
            Console.WriteLine("." + string.Concat(Enumerable.Repeat(ornament, (width / 2))));
            Console.ResetColor();
            Console.WriteLine();

        }

        public void color(string text)
        {
            string[] parts = Regex.Split(text, @"((?=\<).*?(?<=\>))");

            foreach (string item in parts)
            {
                switch (item.ToLower())
                {
                    case "<black>":
                    case "<bk>":
                    case "<k>":
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "<blue>":
                    case "<bl>":
                    case "<b>":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "<cyan>":
                    case "<cy>":
                    case "<c>":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "<gray>":
                    case "<grey>":
                    case "<gy>":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "<green>":
                    case "<gn>":
                    case "<g>":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "<magenta>":
                    case "<purple>":
                    case "<m>":
                    case "<pl>":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "<red>":
                    case "<rd>":
                    case "<r>":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "<white>":
                    case "<wh>":
                    case "<w>":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "<yellow>":
                    case "<yel>":
                    case "<y>":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "</>":
                        Console.ResetColor();
                        break;
                    default:
                        Console.Write(item);
                        break;
                }
            }
        }
        public void line(string text)
        {
            color(text);
            Console.WriteLine();
        }

        public string prompt()
        {
            color("<g>> <b>");
            string input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }
    }
}
