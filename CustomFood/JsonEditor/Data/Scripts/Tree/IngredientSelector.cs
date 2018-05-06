using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void IngredientSelector(Item item, int itemNo)
        {
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
            var str = item.ToString();
            Config.TryGet(ref ing1, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient1", "Item");
            Config.TryGet(ref ing1a, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient1", "Amount");
            Config.TryGet(ref ing2, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient2", "Item");
            Config.TryGet(ref ing2a, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient2", "Amount");
            Config.TryGet(ref ing3, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient3", "Item");
            Config.TryGet(ref ing3a, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient3", "Amount");
            Config.TryGet(ref ing4, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient4", "Item");
            Config.TryGet(ref ing4a, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient4", "Amount");
            Config.TryGet(ref ing5, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient5", "Item");
            Config.TryGet(ref ing5a, $"{str}s", $"{str}{itemNo}", "Ingredients", "Ingredient5", "Amount");
            IngredientSelector(item, itemNo, ing1a, ing1, ing2a, ing2, ing3a, ing3, ing4a, ing4, ing5a, ing5);
        }
        public static void IngredientSelector(Item item, int itemNo, int ing1a, string ing1, int ing2a, string ing2, int ing3a, string ing3, int ing4a, string ing4, int ing5a, string ing5)
        {
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{itemNo} > Ingredients", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", LightGray);
            Console.WriteLine("");
            Console.Write($"1. Edit Ingredient1: ", LightGray);
            Console.WriteLine($"{ing1a}x {ing1}", White);
            Console.Write($"2. Edit Ingredient2: ", LightGray);
            Console.WriteLine($"{ing2a}x {ing2}", White);
            Console.Write($"3. Edit Ingredient3: ", LightGray);
            Console.WriteLine($"{ing3a}x {ing3}", White);
            Console.Write($"4. Edit Ingredient4: ", LightGray);
            Console.WriteLine($"{ing4a}x {ing4}", White);
            Console.Write($"5. Edit Ingredient5: ", LightGray);
            Console.WriteLine($"{ing5a}x {ing5}", White);
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                IngredientEditSelector(1, item, itemNo, ing1a, ing1);
            }
            if (key == '2')
            {
                IngredientEditSelector(2, item, itemNo, ing2a, ing2);
            }
            if (key == '3')
            {
                IngredientEditSelector(3, item, itemNo, ing3a, ing3);
            }
            if (key == '4')
            {
                IngredientEditSelector(4, item, itemNo, ing4a, ing4);
            }
            if (key == '5')
            {
                IngredientEditSelector(5, item, itemNo, ing5a, ing5);
            }
            if (key == '0')
            {
                ItemEditor(item, itemNo);
            }
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 12);
            goto key_invalid;
        }
    }
}
