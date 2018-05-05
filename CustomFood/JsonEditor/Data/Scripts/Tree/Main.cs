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
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine(">", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. EXIT", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("1. Edit Cakes", System.Drawing.Color.LightGray);
            Console.WriteLine("2. Edit Juices", System.Drawing.Color.LightGray);
            var _debug = false;
            Config.TryGet(ref _debug, "Enable debugging");
            Console.Write($"3. Enable debugging: ", System.Drawing.Color.LightGray);
            if (_debug)
            {
                Console.Write("Yes ", System.Drawing.Color.LimeGreen);
            }
            else
            {
                Console.Write("No ", System.Drawing.Color.Red);
            }
            Console.WriteLine("(FEATURE NOT YET IMPLEMENTED)", System.Drawing.Color.Red);
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

