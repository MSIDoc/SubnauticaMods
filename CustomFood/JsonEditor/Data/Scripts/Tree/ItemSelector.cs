using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void ItemSelector(Item item)
        {
            var str = item.ToString();
            var lower = str.ToLower();
            var disabled = " ";
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a number to select", LightGray);
            Console.WriteLine("");
            Console.WriteLine("0. BACK", LightGray);
            Console.WriteLine("");
            var enabled1 = true;
            Config.TryGet(ref enabled1, $"{str}s", $"{str}1", "Enabled");
            if (enabled1 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"1. {str}1 ", LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled2 = true;
            Config.TryGet(ref enabled2, $"{str}s", $"{str}2", "Enabled");
            if (enabled2 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"2. {str}2 ", LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled3 = true;
            Config.TryGet(ref enabled3, $"{str}s", $"{str}3", "Enabled");
            if (enabled3 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"3. {str}3 ", LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled4 = true;
            Config.TryGet(ref enabled4, $"{str}s", $"{str}4", "Enabled");
            if (enabled4 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"4. {str}4 ", LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled5 = true;
            Config.TryGet(ref enabled5, $"{str}s", $"{str}5", "Enabled");
            if (enabled5 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"5. {str}5 ", LightGray);
            Console.WriteLine(disabled, System.Drawing.Color.Orange);
            disabled = " ";
            var enabled6 = true;
            Config.TryGet(ref enabled6, $"{str}s", $"{str}6", "Enabled");
            if (enabled6 == false)
            {
                disabled = "(DISABLED)";
            }
            Console.Write($"6. {str}6 ", LightGray);
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
    }
}
