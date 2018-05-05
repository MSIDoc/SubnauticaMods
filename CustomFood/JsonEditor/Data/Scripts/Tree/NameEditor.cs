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
            Console.WriteLine($"CustomFood Json Editor {version}", System.Drawing.Color.LightGray);
            Console.WriteLine("Created by AlexejheroYTB and yenzgaming", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine($"> {str}s > {str}{i} > Name", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", System.Drawing.Color.LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", System.Drawing.Color.LightGray);
            Console.WriteLine("");
            Console.Write($"CURRENT VALUE: ", System.Drawing.Color.LightGray);
            Console.WriteLine(name, System.Drawing.Color.White);
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
                Console.WriteLine("ERROR: You must type a name", System.Drawing.Color.Red);
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
