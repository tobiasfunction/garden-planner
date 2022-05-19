using System;
using System.Text.RegularExpressions;

namespace GardenBox
{
    public class Printer
    {
        public void write(string text) // A homebrew markup formatter
        {
            /*
                Normally in .NET, colorizing Console output requires a new line of code every time you want the color to change.
                This can get really messy and cluttered, especially if you want to colorize specific words or characters in a longer string.
                This Method allows you to write a string using short tags to define color changes.
                It currently only supports `Console.Foreground Color` and does not include the "Dark" variants of each color,
                but tags for background color and the other colors could easily be added.
                I deliberately didn't add special handling for strings that contain angle brackets but don't match a tag,
                so deliberate brackets in the text and misspelled color tags are both treated as normal text.
             */

            string[] parts = Regex.Split(text, @"(\<.*?\>)");   // this Splits your string into an array of strings
                                                                // the Regex seperates our tags without deleting any characters
            foreach (string item in parts)                      // you can play with it at https://regex101.com/r/KOaJ79/
            {
                switch (item.ToLower())
                {
                    case "<black>": // Each color has has a few alternate names/abbreviations for ease of use
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
                    case "</>":                 // a single tag to reset colors, rather than needing end tags for each color
                        Console.ResetColor();   // because that's how .NET works
                        break;
                    default:                    // if the string doesn't match a tag, we write it to the console.
                        Console.Write(item);
                        break;
                }
            }
        }
        public void header() // fancy header box
        {
            int width = 40;
            string headerTitle = " Veggie Calculator ";
            string ornament = "v.";

            // This is a lot of math because I'm trying to make it work with an arbitrary number of characters
            // Right now it works `headerTitle`, including the spaces, has a length of (a multiple of 4) + 2
            Console.Clear();
            // if (headerTitle.Length % 2 == 0)
            // {
            //     headerTitle += " ";
            // }
            line("<g>." + string.Concat(Enumerable.Repeat(ornament, (width / 2))));
            write("." + string.Concat(Enumerable.Repeat(ornament, ((width - headerTitle.Length) / 4))) + "</>");
            write(headerTitle);
            line("<g>." + string.Concat(Enumerable.Repeat(ornament, ((width - headerTitle.Length) / 4))));
            line("." + string.Concat(Enumerable.Repeat(ornament, (width / 2))) + "</>\n");
        }

        public void line(string str) // adds a line break to `write()` to keep other code cleaner
        {
            write(str);
            Console.WriteLine();
        }

        public void list(string key, string str) // consistently styled menus and lists
        {
            write($"  <g>{key})</> {str}");
            Console.WriteLine();
        }

        public string read()        // styled `Console.ReadLine()` that returns a value
        {
            write("> <c>");
            string input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }

        public void hold()          // styled `Console.ReadLine()` that does NOT return a value
        {                           // e.g. to keep a loop from progressing until user presses Enter
            write("<c>=></>");      // this is mostly a placeholder for now
            Console.ReadLine();
        }
    }
}