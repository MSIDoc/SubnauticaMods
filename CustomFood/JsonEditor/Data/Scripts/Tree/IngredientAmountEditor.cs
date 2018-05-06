using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;
using System;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void IngredientAmountEditor(int ingno, Item item, int i, int inga)
        {
            changed:;
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Ingredients > Ingredient{ingno} > Amount", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", LightGray);
            Console.WriteLine("");
            Console.Write($"CURRENT VALUE: ", LightGray);
            if (inga < 1)
            {
                Console.WriteLine($"{inga} (INVALID - TOO SMALL)");
            }
            else
            {
                Console.WriteLine(inga, White);
            }
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                IngredientEditSelector(ingno, item, i, inga);
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
                Console.WriteLine("ERROR: The number is too small" + clearline, Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
            else
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The input is not a number or is too big" + clearline, Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
            }
        }
    }
}
