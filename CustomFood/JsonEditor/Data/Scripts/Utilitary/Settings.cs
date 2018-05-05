using Utilites.Config;
using System.IO;
using System.Collections;
using System.Linq;

namespace JsonEditor.Data.Scripts.Utilitary
{
    public class Settings
    {
        public static readonly ConfigFile Config = new ConfigFile(@"../../../config");
        public static readonly ConfigFile Setting = new ConfigFile(@"../../settings");
        public enum Item
        {
            Cake,
            Juice
        }
        public static Item Cake = Item.Cake;
        public static Item Juice = Item.Juice;
        public static string version = File.ReadLines("data.txt").Skip(3).Take(1).First();
        public static string clearline = "                                                                                  ";
    }
}
