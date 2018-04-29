using System;
using System.Windows.Forms;
using Utilites.Config;
using Console = Colorful.Console;

namespace JsonEditor
{
    public class CustomFoodJsonEditor
    {
        public static void WinForms(bool bl = false)
        {
            if (bl == false) return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public static readonly ConfigFile Config = new ConfigFile(@"../../../config");
        public static readonly ConfigFile Setting = new ConfigFile(@"../../settings");
        public enum Item
        {
            Cake,
            Juice
        }
        public static Item Cake = Item.Cake;
        public static Item Juice = Item.Juice;
        public static void Main()
        {
            WinForms(false);
            Cfg.Load();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor", System.Drawing.Color.LightGray);
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
                Console.WriteLine("True", System.Drawing.Color.LimeGreen);
            }
            else
            {
                Console.WriteLine("False", System.Drawing.Color.Red);
            }
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
        public static void ItemSelector(Item item)
        {
            var str = item.ToString();
            var lower = str.ToLower();
            var disabled = " ";
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            var enabled1 = true;
            Config.TryGet(ref enabled1, $"{str}s", $"{str}1", "Enabled");
            if (enabled1 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"1. {str}1 ", System.Drawing.Color.LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled2 = true;
            Config.TryGet(ref enabled2, $"{str}s", $"{str}2", "Enabled");
            if (enabled2 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"2. {str}2 ", System.Drawing.Color.LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled3 = true;
            Config.TryGet(ref enabled3, $"{str}s", $"{str}3", "Enabled");
            if (enabled3 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"3. {str}3 ", System.Drawing.Color.LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled4 = true;
            Config.TryGet(ref enabled4, $"{str}s", $"{str}4", "Enabled");
            if (enabled4 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"4. {str}4 ", System.Drawing.Color.LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled5 = true;
            Config.TryGet(ref enabled5, $"{str}s", $"{str}5", "Enabled");
            if (enabled5 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"5. {str}5 ", System.Drawing.Color.LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled6 = true;
            Config.TryGet(ref enabled6, $"{str}s", $"{str}6", "Enabled");
            if (enabled6 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"6. {str}6 ", System.Drawing.Color.LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);

            disabled = " ";
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                ItemEditor(item, 1);
            }
            if (key == '2')
            {
                ItemEditor(item, 2);
            }
            if (key == '3')
            {
                ItemEditor(item, 3);
            }
            if (key == '4')
            {
                ItemEditor(item, 4);
            }
            if (key == '5')
            {
                ItemEditor(item, 5);
            }
            if (key == '6')
            {
                ItemEditor(item, 6);
            }
            if (key == '0')
            {
                Main();
            }
            Console.SetCursorPosition(0, 14);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 14);
            goto key_invalid;
        }
        public static void ItemEditor(Item item, int i)
        {
            changed:;
            var str = item.ToString();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor", System.Drawing.Color.LightGray);
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
                Console.WriteLine("True", System.Drawing.Color.LimeGreen);
            }
            else
            {
                Console.WriteLine("False", System.Drawing.Color.Red);
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
            Console.WriteLine("Default", System.Drawing.Color.LightGray);
            colordone:;
            var ing1 = "None";
            var ing1a = 1;
            var ing2 = "None";
            var ing2a = 1;
            Config.TryGet(ref ing1, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Item");
            Config.TryGet(ref ing1a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Amount");
            Config.TryGet(ref ing2, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Item");
            Config.TryGet(ref ing2a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Amount");
            Console.WriteLine($"3. Ingredients: {ing1a}x {ing1} + {ing2a}x {ing2}", System.Drawing.Color.LightGray);
            var name = "Name";
            Config.TryGet(ref name, $"{str}s", $"{str}{i}", "Name");
            Console.WriteLine($"4. Name: \"{name}\"", System.Drawing.Color.LightGray);
            var x = 1;
            var y = 1;
            Config.TryGet(ref x, $"{str}s", $"{str}{i}", "Size", "X");
            Config.TryGet(ref y, $"{str}s", $"{str}{i}", "Size", "Y");
            Console.WriteLine($"5. Size: {x}x{y}", System.Drawing.Color.LightGray);
            var tooltip = "Tooltip";
            Config.TryGet(ref tooltip, $"{str}s", $"{str}{i}", "Tooltip");
            Console.WriteLine($"6. Tooltip: \"{tooltip}\"", System.Drawing.Color.LightGray);
            var food = 1;
            var water = 1;
            Config.TryGet(ref food, $"{str}s", $"{str}{i}", "Values", "Food");
            Config.TryGet(ref water, $"{str}s", $"{str}{i}", "Values", "Water");
            Console.WriteLine($"7. Values: {water} H2O, {food} FOOD", System.Drawing.Color.LightGray);
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
                Ingredients(item, i, ing1a, ing1, ing2a, ing2);
            }
            if (key == '4')
            {
                //Name(item, i);
            }
            if (key == '5')
            {
                //Size(item, i);
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
            Console.SetCursorPosition(0, 19);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 19);
            goto key_invalid;
        }
        public static void Color(Item item, int i, string color)
        {
            try
            {
                changed:;
                var str = item.ToString();
                var configstring = "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'";
                Console.Clear();
                Console.Title = "CustomFood Json Editor";
                Console.WriteLine("CustomFood Json Editor", System.Drawing.Color.LightGray);
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
                Console.WriteLine("Default (Default)", System.Drawing.Color.LightGray);
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
                Console.WriteLine("R. Reset (Default)", System.Drawing.Color.LightGray);
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
                if (key == 'r')
                {
                    Config.Set($"{str}s", $"{str}{i}", configstring, "Default");
                    Config.Save();
                    color = "Default";
                    goto changed;
                }
                if (key == 'R')
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
            catch { }
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
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK");
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
        public static void IngredientEditor(int ingno, Item item, int i, int inga, string ing)
        {
            var str = item.ToString();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor", System.Drawing.Color.LightGray);
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
                //IngredientItemEditor(ingno, item, i, ing);
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
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor", System.Drawing.Color.LightGray);
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
                Config.Set($"{str}s", $"{str}{i}", "Ingredients", $"Ingredient{ingno}", "Amount", value);
                if (value < 1)
                {
                    goto toosmall;
                }
                Config.Save();
                inga = value;
                goto changed;
                toosmall:;
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The number is too small", System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
            else
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The input is not a number or is too big", System.Drawing.Color.Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
        }
    }
}

