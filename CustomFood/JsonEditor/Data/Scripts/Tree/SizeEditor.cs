using Console = Colorful.Console;
using static JsonEditor.Data.Scripts.Utilitary.Settings;
using System;

namespace JsonEditor.Data.Scripts
{
    public partial class Tree
    {
        public static void SizeEditor(Item item, int i, int size, char whatsize)
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
            Console.WriteLine($"> {str}s > {str}{i} > Size > {whatsize.ToString()}", LightGray);
            Console.WriteLine("");
            Console.WriteLine("Type a new value and press enter to change", LightGray);
            Console.WriteLine("Type \"back\" and press enter to go back", LightGray);
            Console.WriteLine("");
            Console.Write($"CURRENT VALUE: ", LightGray);
            if (size < 1)
            {
                Console.WriteLine($"{size} (INVALID - TOO SMALL)");
                goto afterWrite;
            }
            if (whatsize == 'X')
            {
                if (size > 6)
                {
                    Console.WriteLine($"{size} (INVALID - TOO BIG)");
                    goto afterWrite;
                }
            }
            if (whatsize == 'Y')
            {
                if (size > 8)
                {
                    Console.WriteLine($"{size} (INVALID - TOO BIG)");
                    goto afterWrite;
                }
            }
            Console.WriteLine(size, White);
            afterWrite:;
            Console.WriteLine("");
            key_invalid:;
            var key = Console.ReadLine();
            if (key.ToLower() == "back")
            {
                if (whatsize == 'X')
                {
                    SizeSelector(item, i, size);
                }
                if (whatsize == 'Y')
                {
                    SizeSelector(item, i, size, true);
                }
            }
            if (Int32.TryParse(key, out int value))
            {
                Int32.TryParse(key, out value);
                if (value < 1)
                {
                    goto toosmall;
                }
                if (whatsize == 'X')
                {
                    if (value > 6)
                    {
                        goto toobig;
                    }
                }
                if (whatsize == 'Y')
                {
                    if (value > 8)
                    {
                        goto toobig;
                    }
                }
                Config.Set($"{str}s", $"{str}{i}", "Size", whatsize.ToString(), value);
                Config.Save();
                size = value;
                goto changed;
                toosmall:;
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The number is too small" + clearline, Red);
                Console.SetCursorPosition(0, 10);
                goto key_invalid;
                toobig:;
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(clearline);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("ERROR: The number is too big" + clearline, Red);
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
