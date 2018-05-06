using System;
using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;
using OurConfig = JsonEditor.Data.Scripts.Utilitary.Config;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void Main()
        {
            OurConfig.Load();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine(">", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. EXIT", LightGray);
            Console.WriteLine("");
            Console.WriteLine("1. Edit Cakes", LightGray);
            Console.WriteLine("2. Edit Juices", LightGray);
            var _debug = false;
            Config.TryGet(ref _debug, "Enable debugging");
            Console.Write($"3. Enable debugging: ", LightGray);
            if (_debug)
            {
                Console.Write("Yes ", System.Drawing.Color.LimeGreen);
            }
            else
            {
                Console.Write("No ", Red);
            }
            Console.WriteLine("(FEATURE NOT YET IMPLEMENTED)", Red);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                ItemSelector(Cake);
            }
            if (key == '2')
            {
                ItemSelector(Juice);
            }
            if (key == '0')
            {
                Environment.Exit(0);
            }
            Console.SetCursorPosition(0, 13);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 13);
            goto key_invalid;
        }
    }
}

