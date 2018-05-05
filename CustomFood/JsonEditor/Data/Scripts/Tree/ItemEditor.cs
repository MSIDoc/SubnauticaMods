using System;
using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void ItemEditor(Item item, int i)
        {
            changed:;
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            var enabled = true;
            Config.TryGet(ref enabled, $"{str}s", $"{str}{i}", "Enabled");
            Console.Write($"1. Enabled: ", System.Drawing.Color.LightGray);
            if (enabled)
            {
                Console.WriteLine("Yes", System.Drawing.Color.LimeGreen);
            }
            else
            {
                Console.WriteLine("No", System.Drawing.Color.Red);
            }
            var color = "Default";
            Config.TryGet(ref color, $"{str}s", $"{str}{i}", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'");
            Console.Write($"2. Icon color: ", System.Drawing.Color.LightGray);
            if (color == "Blue")
            {
                Console.WriteLine("Blue", System.Drawing.Color.Blue);
                goto colordone;
            }
            if (color == "BlueGreen")
            {
                Console.WriteLine("Turquoise", System.Drawing.Color.Aquamarine);
                goto colordone;
            }
            if (color == "Green")
            {
                Console.WriteLine("Green", System.Drawing.Color.LimeGreen);
                goto colordone;
            }
            if (color == "LightBlue")
            {
                Console.WriteLine("Light Blue", System.Drawing.Color.Aqua);
                goto colordone;
            }
            if (color == "Orange")
            {
                Console.WriteLine("Orange", System.Drawing.Color.Orange);
                goto colordone;
            }
            if (color == "Pink")
            {
                Console.WriteLine("Pink", System.Drawing.Color.Magenta);
                goto colordone;
            }
            if (color == "Purple")
            {
                Console.WriteLine("Purple", System.Drawing.Color.DarkMagenta);
                goto colordone;
            }
            if (color == "Red")
            {
                Console.WriteLine("Red", System.Drawing.Color.Red);
                goto colordone;
            }
            if (color == "Yellow")
            {
                Console.WriteLine("Yellow", System.Drawing.Color.Yellow);
                goto colordone;
            }
            if (color == "Default")
            {
                Console.WriteLine("Default", System.Drawing.Color.White);
                goto colordone;
            }
            colordone:;
            var ing1 = "SomethingPlaceholder";
            var ing1a = -1;
            var ing2 = "SomethingPlaceholder";
            var ing2a = -1;
            Config.TryGet(ref ing1, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Item");
            Config.TryGet(ref ing1a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Amount");
            Config.TryGet(ref ing2, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Item");
            Config.TryGet(ref ing2a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Amount");
            Console.Write($"3. Ingredients: ", System.Drawing.Color.LightGray);
            Console.Write($"{ing1a}x {ing1} + {ing2a}x {ing2}", System.Drawing.Color.White);
            Console.WriteLine(" (FEATURE DISABLED UNTIL NEXT CUSTOMFOOD UPDATE)", System.Drawing.Color.Red);
            var name = "Name_Missing";
            Config.TryGet(ref name, $"{str}s", $"{str}{i}", "Name");
            Console.Write($"4. Name: ", System.Drawing.Color.LightGray);
            Console.WriteLine($"\"{name}\"", System.Drawing.Color.White);
            var x = -1;
            var y = -1;
            Config.TryGet(ref x, $"{str}s", $"{str}{i}", "Size", "X");
            Config.TryGet(ref y, $"{str}s", $"{str}{i}", "Size", "Y");
            Console.Write($"5. Size: ", System.Drawing.Color.LightGray);
            Console.WriteLine($"{x}x{y}", System.Drawing.Color.White);
            var tooltip = "Tooltip_Missing";
            Config.TryGet(ref tooltip, $"{str}s", $"{str}{i}", "Tooltip");
            Console.Write($"6. Tooltip: ", System.Drawing.Color.LightGray);
            Console.Write($"\"{tooltip}\" ", System.Drawing.Color.White);
            Console.WriteLine("(FEATURE NOT YET IMPLEMENTED)", System.Drawing.Color.Red);
            var food = -1337;
            var water = -1337;
            Config.TryGet(ref food, $"{str}s", $"{str}{i}", "Values", "Food");
            Config.TryGet(ref water, $"{str}s", $"{str}{i}", "Values", "Water");
            Console.Write($"7. Values: ", System.Drawing.Color.LightGray);
            Console.Write($"+{water} H2O, +{food} FOOD ", System.Drawing.Color.White);
            Console.WriteLine("(FEATURE NOT YET IMPLEMENTED)", System.Drawing.Color.Red);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                var change = false;
                if (enabled == false)
                {
                    change = true;
                }
                Config.Set($"{str}s", $"{str}{i}", "Enabled", change);
                Config.Save();
                goto changed;
            }
            if (key == '2')
            {
                ColorEditor(item, i, color);
            }
            if (key == '3')
            {
                //Ingredients(item, i, ing1a, ing1, ing2a, ing2);
            }
            if (key == '4')
            {
                NameEditor(item, i, name);
            }
            if (key == '5')
            {
                SizeSelector(item, i, x, y);
            }
            if (key == '6')
            {
                //Tooltip(item, i);
            }
            if (key == '7')
            {
                //Values(item, i);
            }
            if (key == '0')
            {
                ItemSelector(item);
            }
            Console.SetCursorPosition(0, 17);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 17);
            goto key_invalid;
        }
    }
}
