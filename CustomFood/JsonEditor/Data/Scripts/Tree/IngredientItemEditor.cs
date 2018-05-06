using System;
using static JsonEditor.Data.Scripts.Utilitary.Settings;
using Console = Colorful.Console;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void IngredientItemEditor(int ingno, Item item, int i, string ing)
        {
            changed:;
            var str = item.ToString();
            var clearline = "                                                                                  ";
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients > Ingredient{ingno} > Item", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", LightGray);
            Console.WriteLine("");
            Console.Write($"CURRENT VALUE: ", LightGray);
            if (Enum.TryParse(ing, true, out TechType toType))
            {
                ing = toType.ToString();
                Console.WriteLine(ing, White);
            }
            else
            {
                Console.WriteLine($"{ing} (INVALID - NOT AN ITEM)");
            }
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                Enum.TryParse(ing, true, out TechType res);
                var upcase = res.ToString();
                IngredientEditSelector(ingno, item, i, upcase);
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
                Console.WriteLine("ERROR: That item does not exist", Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
        }
    }
}
