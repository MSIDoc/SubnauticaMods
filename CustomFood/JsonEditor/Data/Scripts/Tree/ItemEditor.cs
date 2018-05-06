using System;
using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;
using static JsonEditor.Data.Scripts.Utilitary.Ingredients;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void ItemEditor(Item item, int i)
        {
            #region Write basics
            changed:;
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i}", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", LightGray);
            Console.WriteLine("");
            #endregion
            #region Write enabled
            var enabled = true;
            Config.TryGet(ref enabled, $"{str}s", $"{str}{i}", "Enabled");
            Console.Write($"1. Enabled: ", LightGray);
            if (enabled)
            {
                Console.WriteLine("Yes", System.Drawing.Color.LimeGreen);
            }
            else
            {
                Console.WriteLine("No", Red);
            }
            #endregion
            #region Write color
            var color = "Default";
            Config.TryGet(ref color, $"{str}s", $"{str}{i}", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'");
            Console.Write($"2. Icon color: ", LightGray);
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
                Console.WriteLine("Red", Red);
                goto colordone;
            }
            if (color == "Yellow")
            {
                Console.WriteLine("Yellow", System.Drawing.Color.Yellow);
                goto colordone;
            }
            if (color == "Default")
            {
                Console.WriteLine("Default", White);
                goto colordone;
            }
            colordone:;
            #endregion
            #region Write ingredients
            var ing1 = "SomethingPlaceholder";
            var ing1a = -1;
            var ing2 = "SomethingPlaceholder";
            var ing2a = -1;
            var ing3 = "SomethingPlaceholder";
            var ing3a = -1;
            var ing4 = "SomethingPlaceholder";
            var ing4a = -1;
            var ing5 = "SomethingPlaceholder";
            var ing5a = -1;
            Config.TryGet(ref ing1, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Item");
            Config.TryGet(ref ing1a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient1", "Amount");
            Config.TryGet(ref ing2, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Item");
            Config.TryGet(ref ing2a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient2", "Amount");
            Config.TryGet(ref ing3, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient3", "Item");
            Config.TryGet(ref ing3a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient3", "Amount");
            Config.TryGet(ref ing4, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient4", "Item");
            Config.TryGet(ref ing4a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient4", "Amount");
            Config.TryGet(ref ing5, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient5", "Item");
            Config.TryGet(ref ing5a, $"{str}s", $"{str}{i}", "Ingredients", "Ingredient5", "Amount");
            CheckIngredients(ing1, ing1a);
            CheckIngredients(ing2, ing2a);
            CheckIngredients(ing3, ing3a);
            CheckIngredients(ing4, ing4a);
            CheckIngredients(ing5, ing5a);
            Console.Write($"3. Ingredients: ", LightGray);
            if (ingredients.Count == 0)
            {
                Console.Write($"NO VALID INGREDIENTS", Red);
            }
            if (ingredients.Count == 1)
            {
                Console.Write($"{ingredients.GetLast().amount.ToString()}x {ingredients.GetLast().techType.ToString()}", White);
            }
            if (ingredients.Count == 2)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);

                Console.Write($"{ingredients.GetLast().amount.ToString()}x {ingredients.GetLast().techType.ToString()} + ", White);
                Console.Write($"{i1.amount.ToString()}x {i1.techType.ToString()}", White);
            }
            if (ingredients.Count == 3)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);
                var i2 = ingredients.GetLast();
                ingredients.Remove(i2);

                Console.Write($"{ingredients.GetLast().amount.ToString()}x {ingredients.GetLast().techType.ToString()} + ", White);
                Console.Write($"{i2.amount.ToString()}x {i2.techType.ToString()} + ", White);
                Console.Write($"{i1.amount.ToString()}x {i1.techType.ToString()}", White);
            }
            if (ingredients.Count == 4)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);
                var i2 = ingredients.GetLast();
                ingredients.Remove(i2);
                var i3 = ingredients.GetLast();
                ingredients.Remove(i3);

                Console.Write($"{ingredients.GetLast().amount.ToString()}x {ingredients.GetLast().techType.ToString()} + ", White);
                Console.Write($"{i3.amount.ToString()}x {i3.techType.ToString()} + ", White);
                Console.Write($"{i2.amount.ToString()}x {i2.techType.ToString()} + ", White);
                Console.Write($"{i1.amount.ToString()}x {i1.techType.ToString()}", White);
            }
            if (ingredients.Count == 5)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);
                var i2 = ingredients.GetLast();
                ingredients.Remove(i2);
                var i3 = ingredients.GetLast();
                ingredients.Remove(i3);
                var i4 = ingredients.GetLast();
                ingredients.Remove(i4);

                Console.Write($"{ingredients.GetLast().amount.ToString()}x {ingredients.GetLast().techType.ToString()} + ", White);
                Console.Write($"{i4.amount.ToString()}x {i4.techType.ToString()} + ", White);
                Console.Write($"{i3.amount.ToString()}x {i3.techType.ToString()} + ", White);
                Console.Write($"{i2.amount.ToString()}x {i2.techType.ToString()} + ", White);
                Console.Write($"{i1.amount.ToString()}x {i1.techType.ToString()}", White);
            }
            Console.WriteLine(" ");
            ingredients.Clear();
            #endregion
            #region Write name
            var name = "Name_Missing";
            Config.TryGet(ref name, $"{str}s", $"{str}{i}", "Name");
            Console.Write($"4. Name: ", LightGray);
            Console.WriteLine($"\"{name}\"", White);
            #endregion
            #region Write size
            var x = -1;
            var y = -1;
            Config.TryGet(ref x, $"{str}s", $"{str}{i}", "Size", "X");
            Config.TryGet(ref y, $"{str}s", $"{str}{i}", "Size", "Y");
            Console.Write($"5. Size: ", LightGray);
            Console.WriteLine($"{x}x{y}", White);
            #endregion
            #region Write tooltip
            var tooltip = "Tooltip_Missing";
            Config.TryGet(ref tooltip, $"{str}s", $"{str}{i}", "Tooltip");
            Console.Write($"6. Tooltip: ", LightGray);
            Console.Write($"\"{tooltip}\" ", White);
            Console.WriteLine("(FEATURE NOT YET IMPLEMENTED)", Red);
            #endregion
            #region Write values
            var food = -1337;
            var water = -1337;
            Config.TryGet(ref food, $"{str}s", $"{str}{i}", "Values", "Food");
            Config.TryGet(ref water, $"{str}s", $"{str}{i}", "Values", "Water");
            Console.Write($"7. Values: ", LightGray);
            Console.Write($"+{water} H2O, +{food} FOOD ", White);
            Console.WriteLine("(FEATURE NOT YET IMPLEMENTED)", Red);
            Console.WriteLine("");
            #endregion
            #region Input
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
                IngredientSelector(item, i, ing1a, ing1, ing2a, ing2, ing3a, ing3, ing4a, ing4, ing5a, ing5);
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
            #endregion
        }
    }
}
