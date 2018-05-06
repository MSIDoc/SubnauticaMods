using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void NameEditor(Item item, int i, string name)
        {
            changed:;
            var str = item.ToString();
            Console.ReplaceAllColorsWithDefaults();
            Console.Clear();
            Console.Title = "CustomFood Json Editor";
            Console.WriteLine($"CustomFood Json Editor {version}", LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Name", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", LightGray);
            Console.WriteLine("");
            Console.Write($"CURRENT VALUE: ", LightGray);
            if (string.IsNullOrEmpty(name) | string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine($"{name} (INVALID - THE NAME IS EMPTY)", Red);
            }
            else
            {
                Console.WriteLine(name, White);
            }
            Console.WriteLine("");
            key_null:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                ItemEditor(item, i);
            }
            if (string.IsNullOrEmpty(key) | string.IsNullOrWhiteSpace(key))
            {
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: You must type a name", Red);
                Console.SetCursorPosition(0, 10);
                goto key_null;
            }
            else
            {
                Config.Set($"{str}s", $"{str}{i}", "Name", key.Trim());
                Config.Save();
                name = key.Trim();
                goto changed;
            }
        }
    }
}
