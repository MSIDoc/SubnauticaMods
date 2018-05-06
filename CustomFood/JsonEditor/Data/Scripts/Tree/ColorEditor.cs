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
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Color", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number/letter to select", LightGray);
            Console.WriteLine("");
            Console.Write("CURRENT VALUE: ", LightGray);
            if (color == "Blue")
            {
                Console.Write("Blue", System.Drawing.Color.Blue);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "BlueGreen")
            {
                Console.Write("Turquoise", System.Drawing.Color.Aquamarine);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "Green")
            {
                Console.Write("Green", System.Drawing.Color.LimeGreen);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "LightBlue")
            {
                Console.Write("Light Blue", System.Drawing.Color.Aqua);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "Orange")
            {
                Console.Write("Orange", System.Drawing.Color.Orange);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "Pink")
            {
                Console.Write("Pink", System.Drawing.Color.Magenta);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "Purple")
            {
                Console.Write("Purple", System.Drawing.Color.DarkMagenta);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "Red")
            {
                Console.Write("Red", Red);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            if (color == "Yellow")
            {
                Console.Write("Yellow", System.Drawing.Color.Yellow);
                Console.WriteLine($" ({color})", LightGray);
                goto colordone;
            }
            Console.WriteLine($"{color} (INVALID - NOT A VALID COLOR)", Red);
            colordone:;
            Console.WriteLine("");
            Console.WriteLine("0. BACK", LightGray);
            Console.WriteLine("");
            Console.Write("1. Set to", LightGray);
            Console.Write(" Blue ", System.Drawing.Color.Blue);
            Console.WriteLine("(Blue)", LightGray);
            Console.Write("2. Set to", LightGray);
            Console.Write(" Turquoise ", System.Drawing.Color.Aquamarine);
            Console.WriteLine("(BlueGreen)", LightGray);
            Console.Write("3. Set to", LightGray);
            Console.Write(" Green ", System.Drawing.Color.LimeGreen);
            Console.WriteLine("(Green)", LightGray);
            Console.Write("4. Set to", LightGray);
            Console.Write(" Light Blue ", System.Drawing.Color.Aqua);
            Console.WriteLine("(LightBlue)", LightGray);
            Console.Write("5. Set to", LightGray);
            Console.Write(" Orange ", System.Drawing.Color.Orange);
            Console.WriteLine("(Orange)", LightGray);
            Console.Write("6. Set to", LightGray);
            Console.Write(" Pink ", System.Drawing.Color.Magenta);
            Console.WriteLine("(Pink)", LightGray);
            Console.Write("7. Set to", LightGray);
            Console.Write(" Purple ", System.Drawing.Color.DarkMagenta);
            Console.WriteLine("(Purple)", LightGray);
            Console.Write("8. Set to", LightGray);
            Console.Write(" Red ", Red);
            Console.WriteLine("(Red)", LightGray);
            Console.Write("9. Set to", LightGray);
            Console.Write(" Yellow ", System.Drawing.Color.Yellow);
            Console.WriteLine("(Yellow)", LightGray);
            Console.Write("R. Set to", LightGray);
            Console.Write(" Default ", White);
            Console.WriteLine("(Default)", LightGray);
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
