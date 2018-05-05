using static JsonEditor.Data.Scripts.Utilitary.Settings;
using Console = Colorful.Console;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void SizeSelector(Item item, int i, int x)
        {
            var str = item.ToString();
            var y = -1;
            Config.TryGet(ref y, $"{str}s", $"{str}{i}", "Size", "Y");
            SizeSelector(item, i, x, y);
        }
        public static void SizeSelector(Item item, int i, int y, bool yIdentifier)
        {
            var str = item.ToString();
            var x = -1;
            Config.TryGet(ref x, $"{str}s", $"{str}{i}", "Size", "X");
            SizeSelector(item, i, x, y);
        }
        public static void SizeSelector(Item item, int i, int x, int y)
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
    }
}
