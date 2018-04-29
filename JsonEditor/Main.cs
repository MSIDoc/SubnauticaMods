using System;
using System.Windows.Forms;
using Utilites.Config;

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
            Console.WriteLine("CustomFood Json Editor");
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming");
            Console.WriteLine("");
            Console.WriteLine(">");
            Console.WriteLine("");
            Console.WriteLine("Type a number to select");
            Console.WriteLine("");
            Console.WriteLine("0. EXIT");
            Console.WriteLine("");
            Console.WriteLine("1. Cakes");
            Console.WriteLine("2. Juices");
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
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 12);
            goto key_invalid;
        }
        public static void ItemSelector(Item item)
        {
            var str = item.ToString();
            var lower = str.ToLower();
            var disabled = " ";
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor");
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming");
            Console.WriteLine("");
            Console.WriteLine($"> {str}s");
            Console.WriteLine("");
            Console.WriteLine("Type a number to select");
            Console.WriteLine("");
            Console.WriteLine("0. BACK");
            Console.WriteLine("");
            var enabled1 = true;
            Config.TryGet(ref enabled1, $"{str}s", $"{str}1", "Enabled");
            if (enabled1 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.WriteLine($"1. {str}1 {disabled}");
            disabled = " ";
            var enabled2 = true;
            Config.TryGet(ref enabled2, $"{str}s", $"{str}2", "Enabled");
            if (enabled2 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.WriteLine($"2. {str}2 {disabled}");
            disabled = " ";
            var enabled3 = true;
            Config.TryGet(ref enabled3, $"{str}s", $"{str}3", "Enabled");
            if (enabled3 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.WriteLine($"3. {str}3 {disabled}");
            disabled = " ";
            var enabled4 = true;
            Config.TryGet(ref enabled4, $"{str}s", $"{str}4", "Enabled");
            if (enabled4 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.WriteLine($"4. {str}4 {disabled}");
            disabled = " ";
            var enabled5 = true;
            Config.TryGet(ref enabled5, $"{str}s", $"{str}5", "Enabled");
            if (enabled5 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.WriteLine($"5. {str}5 {disabled}");
            disabled = " ";
            var enabled6 = true;
            Config.TryGet(ref enabled6, $"{str}s", $"{str}6", "Enabled");
            if (enabled6 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.WriteLine($"6. {str}6 {disabled}");
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
            Console.SetCursorPosition(0, 16);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 16);
            goto key_invalid;
        }
        public static void ItemEditor(Item item, int i)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            var str = item.ToString();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor");
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming");
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i}");
            Console.WriteLine("");
            Console.WriteLine("Type a number to select");
            Console.WriteLine("");
            Console.WriteLine("0. BACK");
            Console.WriteLine("");
            var enabled = true;
            Config.TryGet(ref enabled, $"{str}s", $"{str}{i}", "Enabled");
            Console.WriteLine($"1. Enabled: {enabled}");
            var color = "Default";
            Config.TryGet(ref color, $"{str}s", $"{str}{i}", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'");
            Console.WriteLine($"2. Icon color: {color}");
            var ing1 = "None";
            var ing1a = 1;
            var ing2 = "None";
            var ing2a = 1;
            Config.TryGet(ref ing1, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Item");
            Config.TryGet(ref ing1a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Amount");
            Config.TryGet(ref ing2, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Item");
            Config.TryGet(ref ing2a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Amount");
            Console.WriteLine($"3. Ingredients: {ing1a}x {ing1} + {ing2a}x {ing2}");
            var name = "Name";
            Config.TryGet(ref name, $"{str}s", $"{str}{i}", "Name");
            Console.WriteLine($"4. Name: \"{name}\"");
            var x = 1;
            var y = 1;
            Config.TryGet(ref x, $"{str}s", $"{str}{i}", "Size", "X");
            Config.TryGet(ref y, $"{str}s", $"{str}{i}", "Size", "Y");
            Console.WriteLine($"5. Size: {x}x{y}");
            var tooltip = "Tooltip";
            Config.TryGet(ref tooltip, $"{str}s", $"{str}{i}", "Tooltip");
            Console.WriteLine($"6. Tooltip: \"{tooltip}\"");
            var food = 1;
            var water = 1;
            Config.TryGet(ref food, $"{str}s", $"{str}{i}", "Values", "Food");
            Config.TryGet(ref water, $"{str}s", $"{str}{i}", "Values", "Water");
            Console.WriteLine($"7. Values: {water} H2O, {food} FOOD");
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                Enabled(item, i, enabled);
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
        public static void Enabled(Item item, int i, bool enabled)
        {
            changed:;
            var str = item.ToString();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor");
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming");
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Enabled");
            Console.WriteLine("");
            Console.WriteLine("Type a number to select");
            Console.WriteLine("");
            Config.TryGet(ref enabled, $"{str}s", $"{str}{i}", "Enabled");
            Console.WriteLine($"CURRENT VALUE: {enabled}");
            Console.WriteLine("");
            var change = false;
            if (enabled == false)
            {
                change = true;
            }
            Console.WriteLine("0. BACK");
            Console.WriteLine("");
            Console.WriteLine($"1. Set to {change.ToString()}");
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                Config.Set($"{str}s", $"{str}{i}", "Enabled", change);
                Config.Save();
                goto changed;
            }
            if (key == '0')
            {
                ItemEditor(item, i);
            }
            Console.SetCursorPosition(0, 15);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 15);
            goto key_invalid;
        }
        public static void Color(Item item, int i, string color)
        {
            changed:;
            var str = item.ToString();
            var configstring = "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'";
            if (color == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                goto colordone;
            }
            if (color == "BlueGreen")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                goto colordone;
            }
            if (color == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                goto colordone;
            }
            if (color == "LightBlue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                goto colordone;
            }
            if (color == "Orange")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                goto colordone;
            }
            if (color == "Pink")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                goto colordone;
            }
            if (color == "Purple")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                goto colordone;
            }
            if (color == "Red")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                goto colordone;
            }
            if (color == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                goto colordone;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Config.Set($"{str}s", $"{str}{i}", configstring, "Default");
            Config.Save();
            color = "Default";
            colordone:;
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor");
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming");
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Color");
            Console.WriteLine("");
            Console.WriteLine("Type a number/letter to select");
            Console.WriteLine("");
            Console.WriteLine($"CURRENT VALUE: {color}");
            Console.WriteLine("");
            Console.WriteLine("0. BACK");
            Console.WriteLine("");
            Console.WriteLine("1. Set to Blue (Blue)");
            Console.WriteLine("2. Set to Turquoise (BlueGreen)");
            Console.WriteLine("3. Set to Green (Green)");
            Console.WriteLine("4. Set to Light Blue (LightBlue)");
            Console.WriteLine("5. Set to Orange (Orange)");
            Console.WriteLine("6. Set to Pink (Pink)");
            Console.WriteLine("7. Set to Purple (Purple)");
            Console.WriteLine("8. Set to Red (Red)");
            Console.WriteLine("9. Set to Yellow (Yellow)");
            Console.WriteLine("R. Reset (Default)");
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Blue");
                Config.Save();
                goto changed;
            }
            if (key == '2')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "BlueGreen");
                Config.Save();
                goto changed;
            }
            if (key == '3')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Green");
                Config.Save();
                goto changed;
            }
            if (key == '4')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "LightBlue");
                Config.Save();
                goto changed;
            }
            if (key == '5')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Orange");
                Config.Save();
                goto changed;
            }
            if (key == '6')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Pink");
                Config.Save();
                goto changed;
            }
            if (key == '7')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Purple");
                Config.Save();
                goto changed;
            }
            if (key == '8')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Red");
                Config.Save();
                goto changed;
            }
            if (key == '9')
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Yellow");
                Config.Save();
                goto changed;
            }
            if (key.ToString().ToLower() == "r")
            {
                Config.Set($"{str}s", $"{str}{i}", configstring, "Default");
                Config.Save();
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
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor");
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming");
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients");
            Console.WriteLine("");
            Console.WriteLine("Type a number to select");
            Console.WriteLine("");
            Console.WriteLine("0. BACK");
            Console.WriteLine("");
            Console.WriteLine($"1. Edit Ingredient1: {ing1a}x {ing1}");
            Console.WriteLine($"2. Edit Ingredient2: {ing2a}x {ing2}");
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
        public static void IngredientEditor(int ingno, Item item, int i, int inga, string ing)
        {
            var str = item.ToString();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine("CustomFood Json Editor");
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming");
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients > Ingredient{ingno}");
            Console.WriteLine("");
            Console.WriteLine("Type a number to select");
            Console.WriteLine("");
            Console.WriteLine("0. BACK");
            Console.WriteLine("");
            Console.WriteLine($"1. Edit Item: {ing}");
            Console.WriteLine($"2. Edit Amount: {inga}");
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
    }
}

