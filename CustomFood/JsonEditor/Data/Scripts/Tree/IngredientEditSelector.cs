using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;
using System;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void IngredientEditSelector(int ingno, Item item, int itemNo, int inga)
        {
            var ing = "SomethingPlaceholder";
            var str = item.ToString();
            Config.TryGet(ref ing, $"{str}s", $"{str}{itemNo}", "Ingredients", $"Ingredient{ingno}", "Item");
            IngredientEditSelector(ingno, item, itemNo, inga, ing);
        }
        public static void IngredientEditSelector(int ingno, Item item, int itemNo, string ing)
        {
            var inga = -1;
            var str = item.ToString();
            Config.TryGet(ref inga, $"{str}s", $"{str}{itemNo}", "Ingredients", $"Ingredient{ingno}", "Amount");
            IngredientEditSelector(ingno, item, itemNo, inga, ing);
        }
        public static void IngredientEditSelector(int ingno, Item item, int itemNo, int inga, string ing)
        {
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{itemNo} > Ingredients > Ingredient{ingno}", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", LightGray);
            Console.WriteLine("");
            Console.Write($"1. Edit Item: ", LightGray);
            if (Enum.TryParse(ing, true, out TechType toType))
            {
                ing = toType.ToString();
                Console.WriteLine(ing, White);
            }
            else
            {
                Console.WriteLine($"{ing} (INVALID - NOT AN ITEM)");
            }
            Console.Write($"2. Edit Amount: {inga}", LightGray);
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
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                IngredientItemEditor(ingno, item, itemNo, ing);
            }
            if (key == '2')
            {
                IngredientAmountEditor(ingno, item, itemNo, inga);
            }
            if (key == '0')
            {
                IngredientSelector(item, itemNo);
            }
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 12);
            goto key_invalid;
        }
    }
}
