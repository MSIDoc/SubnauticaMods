using System;
using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;
using JsonEditor.Data.Scripts.Utilitary.Config;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void Main()
        {
            Load.Config();
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
                Color(item, i, color);
            }
            if (key == '3')
            {
                //Ingredients(item, i, ing1a, ing1, ing2a, ing2);
            }
            if (key == '4')
            {
                Name(item, i, name);
            }
            if (key == '5')
            {
                Size(item, i, x, y);
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
        public static void Color(Item item, int i, string color)
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
        public static void Ingredients(Item item, int i)
        {
            var ing1 = "None";
            var ing1a = 1;
            var ing2 = "None";
            var ing2a = 1;
            var str = item.ToString();
            Config.TryGet(ref ing1, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Item");
            Config.TryGet(ref ing1a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Amount");
            Config.TryGet(ref ing2, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Item");
            Config.TryGet(ref ing2a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Amount");
            Ingredients(item, i, ing1a, ing1, ing2a, ing2);
        }
        public static void Ingredients(Item item, int i, int ing1a, string ing1, int ing2a, string ing2)
        {
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"1. Edit Ingredient1: {ing1a}x {ing1}", System.Drawing.Color.LightGray);
            Console.WriteLine($"2. Edit Ingredient2: {ing2a}x {ing2}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                IngredientEditor(1, item, i, ing1a, ing1);
            }
            if (key == '2')
            {
                IngredientEditor(2, item, i, ing1a, ing1);
            }
            if (key == '0')
            {
                ItemEditor(item, i);
            }
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 12);
            goto key_invalid;
        }
        public static void IngredientEditor(int ingno, Item item, int i, int inga)
        {
            var ing = "None";
            var str = item.ToString();
            Config.TryGet(ref ing, $"{str}s", $"{str}{i}", "Ingredients", $"Ingredient{ingno}", "Item");
            IngredientEditor(ingno, item, i, inga, ing);
        }
        public static void IngredientEditor(int ingno, Item item, int i, string ing)
        {
            var inga = 1;
            var str = item.ToString();
            Config.TryGet(ref inga, $"{str}s", $"{str}{i}", "Ingredients", $"Ingredient{ingno}", "Amount");
            IngredientEditor(ingno, item, i, inga, ing);
        }
        public static void IngredientEditor(int ingno, Item item, int i, int inga, string ing)
        {
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients > Ingredient{ingno}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"1. Edit Item: {ing}", System.Drawing.Color.LightGray);
            Console.WriteLine($"2. Edit Amount: {inga}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                IngredientItemEditor(ingno, item, i, ing);
            }
            if (key == '2')
            {
                IngredientAmountEditor(ingno, item, i, inga);
            }
            if (key == '0')
            {
                Ingredients(item, i);
            }
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 12);
            goto key_invalid;
        }
        public static void IngredientAmountEditor(int ingno, Item item, int i, int inga)
        {
            changed:;
            var str = item.ToString();
            var clearline = "                                                                                  ";
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients > Ingredient{ingno} > Amount", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", System.Drawing.Color.LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"CURRENT VALUE: {inga}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                IngredientEditor(ingno, item, i, inga);
            }
            if (Int32.TryParse(key, out int value))
            {
                Int32.TryParse(key, out value);
                if (value < 1)
                {
                    goto toosmall;
                }
                Config.Set($"{str}s", $"{str}{i}", "Ingredients", $"Ingredient{ingno}", "Amount", value);
                Config.Save();
                inga = value;
                goto changed;
                toosmall:;
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The number is too small" + clearline, System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
            else
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The input is not a number or is too big" + clearline, System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
        }
        public static void IngredientItemEditor(int ingno, Item item, int i, string ing)
        {
            changed:;
            var str = item.ToString();
            var clearline = "                                                                                  ";
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients > Ingredient{ingno} > Item", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", System.Drawing.Color.LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"CURRENT VALUE: {ing}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                Enum.TryParse(ing, true, out TechType res);
                var upcase = res.ToString();
                IngredientEditor(ingno, item, i, upcase);
            }
            if (Enum.TryParse(key, true, out TechType result))
            {
                var upper = result.ToString();
                Config.Set($"{str}s", $"{str}{i}", "Ingredients", $"Ingredient{ingno}", "Item", upper);
                Config.Save();
                ing = upper;
                goto changed;
            }
            else
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: That item does not exist", System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
        }
        public static void Name(Item item, int i, string name)
        {
            changed:;
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Name", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", System.Drawing.Color.LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.Write($"CURRENT VALUE: ", System.Drawing.Color.LightGray);
            Console.WriteLine(name, System.Drawing.Color.White);
            Console.WriteLine("");
            key_null:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                ItemEditor(item, i);
            }
            if (string.IsNullOrEmpty(key) | string.IsNullOrWhiteSpace(key))
            {
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: You must type a name", System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_null;
            }
            else
            {
                Config.Set($"{str}s", $"{str}{i}", "Name", key.Trim());
                Config.Save();
                name = key.Trim();
                goto changed;
            }
        }
        public static void Size(Item item, int i, int x)
        {
            var str = item.ToString();
            var y = -1;
            Config.TryGet(ref y, $"{str}s", $"{str}{i}", "Size", "Y");
            Size(item, i, x, y);
        }
        public static void Size(Item item, int i, int y, bool yIdentifier)
        {
            var str = item.ToString();
            var x = -1;
            Config.TryGet(ref x, $"{str}s", $"{str}{i}", "Size", "X");
            Size(item, i, x, y);
        }
        public static void Size(Item item, int i, int x, int y)
        {
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Size", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"1. Edit X value: {x}", System.Drawing.Color.LightGray);
            Console.WriteLine($"2. Edit Y value: {y}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                SizeEditor(item, i, x, 'X');
            }
            if (key == '2')
            {
                SizeEditor(item, i, y, 'Y');
            }
            if (key == '0')
            {
                ItemEditor(item, i);
            }
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 12);
            goto key_invalid;
        }
        public static void SizeEditor(Item item, int i, int size, char whatsize)
        {
            changed:;
            var str = item.ToString();
            var clearline = "                                                                                  ";
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Size > {whatsize.ToString()}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", System.Drawing.Color.LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"CURRENT VALUE: {size}", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                if (whatsize == 'X')
                {
                    Size(item, i, size);
                }
                if (whatsize == 'Y')
                {
                    Size(item, i, size, true);
                }
            }
            if (Int32.TryParse(key, out int value))
            {
                Int32.TryParse(key, out value);
                if (value < 1)
                {
                    goto toosmall;
                }
                if (whatsize == 'X')
                {
                    if (value > 6)
                    {
                        goto toobig;
                    }
                }
                if (whatsize == 'Y')
                {
                    if (value > 8)
                    {
                        goto toobig;
                    }
                }
                Config.Set($"{str}s", $"{str}{i}", "Size", whatsize.ToString(), value);
                Config.Save();
                size = value;
                goto changed;
                toosmall:;
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The number is too small" + clearline, System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
                toobig:;
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The number is too big" + clearline, System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
            else
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The input is not a number or is too big" + clearline, System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
        }
    }
}

