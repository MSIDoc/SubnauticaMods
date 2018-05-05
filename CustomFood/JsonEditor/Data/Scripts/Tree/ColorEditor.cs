using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void ColorEditor(Item item, int i, string color)
        {
            changed:;
            var str = item.ToString();
            var configstring = "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'";
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Color", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number/letter to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.Write("CURRENT VALUE: ", System.Drawing.Color.LightGray);
            if (color == "Blue")
            {
                Console.Write("Blue", System.Drawing.Color.Blue);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "BlueGreen")
            {
                Console.Write("Turquoise", System.Drawing.Color.Aquamarine);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "Green")
            {
                Console.Write("Green", System.Drawing.Color.LimeGreen);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "LightBlue")
            {
                Console.Write("Light Blue", System.Drawing.Color.Aqua);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "Orange")
            {
                Console.Write("Orange", System.Drawing.Color.Orange);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "Pink")
            {
                Console.Write("Pink", System.Drawing.Color.Magenta);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "Purple")
            {
                Console.Write("Purple", System.Drawing.Color.DarkMagenta);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "Red")
            {
                Console.Write("Red", System.Drawing.Color.Red);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            if (color == "Yellow")
            {
                Console.Write("Yellow", System.Drawing.Color.Yellow);
                Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
                goto colordone;
            }
            Config.Set($"{str}s", $"{str}{i}", configstring, "Default");
            Config.Save();
            color = "Default";
            Console.Write("Default", System.Drawing.Color.White);
            Console.WriteLine($" ({color})", System.Drawing.Color.LightGray);
            colordone:;
            Console.WriteLine("");
            Console.WriteLine("0. BACK", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.Write("1. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Blue ", System.Drawing.Color.Blue);
            Console.WriteLine("(Blue)", System.Drawing.Color.LightGray);
            Console.Write("2. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Turquoise ", System.Drawing.Color.Aquamarine);
            Console.WriteLine("(BlueGreen)", System.Drawing.Color.LightGray);
            Console.Write("3. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Green ", System.Drawing.Color.LimeGreen);
            Console.WriteLine("(Green)", System.Drawing.Color.LightGray);
            Console.Write("4. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Light Blue ", System.Drawing.Color.Aqua);
            Console.WriteLine("(LightBlue)", System.Drawing.Color.LightGray);
            Console.Write("5. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Orange ", System.Drawing.Color.Orange);
            Console.WriteLine("(Orange)", System.Drawing.Color.LightGray);
            Console.Write("6. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Pink ", System.Drawing.Color.Magenta);
            Console.WriteLine("(Pink)", System.Drawing.Color.LightGray);
            Console.Write("7. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Purple ", System.Drawing.Color.DarkMagenta);
            Console.WriteLine("(Purple)", System.Drawing.Color.LightGray);
            Console.Write("8. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Red ", System.Drawing.Color.Red);
            Console.WriteLine("(Red)", System.Drawing.Color.LightGray);
            Console.Write("9. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Yellow ", System.Drawing.Color.Yellow);
            Console.WriteLine("(Yellow)", System.Drawing.Color.LightGray);
            Console.Write("R. Set to", System.Drawing.Color.LightGray);
            Console.Write(" Default ", System.Drawing.Color.White);
            Console.WriteLine("(Default)", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Blue");
                Config.Save();
                color = "Blue";
                goto changed;
            }
            if (key == '2')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "BlueGreen");
                Config.Save();
                color = "BlueGreen";
                goto changed;
            }
            if (key == '3')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Green");
                Config.Save();
                color = "Green";
                goto changed;
            }
            if (key == '4')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "LightBlue");
                Config.Save();
                color = "LightBlue";
                goto changed;
            }
            if (key == '5')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Orange");
                Config.Save();
                color = "Orange";
                goto changed;
            }
            if (key == '6')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Pink");
                Config.Save();
                color = "Pink";
                goto changed;
            }
            if (key == '7')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Purple");
                Config.Save();
                color = "Purple";
                goto changed;
            }
            if (key == '8')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Red");
                Config.Save();
                color = "Red";
                goto changed;
            }
            if (key == '9')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Yellow");
                Config.Save();
                color = "Yellow";
                goto changed;
            }
            if (key == 'r' || key == 'R')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Default");
                Config.Save();
                color = "Default";
                goto changed;
            }
            if (key == '0')
            {
                ItemEditor(item, i);
            }
            Console.SetCursorPosition(0, 22);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 22);
            goto key_invalid;
        }
    }
}
