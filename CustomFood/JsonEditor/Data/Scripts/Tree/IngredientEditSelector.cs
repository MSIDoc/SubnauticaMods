using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void IngredientEditSelector(int ingno, Item item, int i, int inga)
        {
            var ing = "None";
            var str = item.ToString();
            Config.TryGet(ref ing, $"{str}s", $"{str}{i}", "Ingredients", $"Ingredient{ingno}", "Item");
            IngredientEditSelector(ingno, item, i, inga, ing);
        }
        public static void IngredientEditSelector(int ingno, Item item, int i, string ing)
        {
            var inga = 1;
            var str = item.ToString();
            Config.TryGet(ref inga, $"{str}s", $"{str}{i}", "Ingredients", $"Ingredient{ingno}", "Amount");
            IngredientEditSelector(ingno, item, i, inga, ing);
        }
        public static void IngredientEditSelector(int ingno, Item item, int i, int inga, string ing)
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
                IngredientSelector(item, i);
            }
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 12);
            goto key_invalid;
        }
    }
}
