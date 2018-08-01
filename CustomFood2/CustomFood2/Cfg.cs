using System;
using SMLHelper.Patchers;
using SMLHelper.V2.Utility;
using UnityEngine;
using Utilites.Config;
using Logger = Utilites.Logger.Logger;

namespace CustomFood2
{
    /// <summary>
    /// Main class for loading or saving the config
    /// </summary>
    public class Cfg
    {
        public static readonly ConfigFile Config = new ConfigFile("config");

        public static bool _debug = false;

        public static string _tooltipsuffix = " - Added by the CustomFood2 mod.";

        public static bool _juice1_enabled = true;
        public static string _juice1_name = "Bulbo Tree Juice";
        public static string _juice1_tooltip = "Water mixed with a Bulbo Tree Sample";
        public static int _juice1_foodvalue = 10;
        public static int _juice1_watervalue = 35;
        public static string _juice1_ingredient1 = "FilteredWater";
        public static int _juice1_ingredient1amount = 1;
        public static string _juice1_ingredient2 = "BulboTreePiece";
        public static int _juice1_ingredient2amount = 1;
        public static string _juice1_ingredient3 = "None";
        public static int _juice1_ingredient3amount = 0;
        public static string _juice1_ingredient4 = "None";
        public static int _juice1_ingredient4amount = 0;
        public static string _juice1_ingredient5 = "None";
        public static int _juice1_ingredient5amount = 0;
        public static int _juice1_x = 1;
        public static int _juice1_y = 1;

        public static bool _juice2_enabled = true;
        public static string _juice2_name = "Lantern Fruit Juice";
        public static string _juice2_tooltip = "Water mixed with a Lantern Fruit";
        public static int _juice2_foodvalue = 10;
        public static int _juice2_watervalue = 35;
        public static string _juice2_ingredient1 = "FilteredWater";
        public static int _juice2_ingredient1amount = 1;
        public static string _juice2_ingredient2 = "HangingFruit";
        public static int _juice2_ingredient2amount = 1;
        public static string _juice2_ingredient3 = "None";
        public static int _juice2_ingredient3amount = 0;
        public static string _juice2_ingredient4 = "None";
        public static int _juice2_ingredient4amount = 0;
        public static string _juice2_ingredient5 = "None";
        public static int _juice2_ingredient5amount = 0;
        public static int _juice2_x = 1;
        public static int _juice2_y = 1;

        public static bool _juice3_enabled = true;
        public static string _juice3_name = "Marblemelon Juice";
        public static string _juice3_tooltip = "Water mixed with a Marblemelon";
        public static int _juice3_foodvalue = 20;
        public static int _juice3_watervalue = 45;
        public static string _juice3_ingredient1 = "FilteredWater";
        public static int _juice3_ingredient1amount = 1;
        public static string _juice3_ingredient2 = "Melon";
        public static int _juice3_ingredient2amount = 1;
        public static string _juice3_ingredient3 = "None";
        public static int _juice3_ingredient3amount = 0;
        public static string _juice3_ingredient4 = "None";
        public static int _juice3_ingredient4amount = 0;
        public static string _juice3_ingredient5 = "None";
        public static int _juice3_ingredient5amount = 0;
        public static int _juice3_x = 1;
        public static int _juice3_y = 1;

        public static bool _juice4_enabled = true;
        public static string _juice4_name = "Creepvine Juice";
        public static string _juice4_tooltip = "Water mixed with a Creepvine Sample";
        public static int _juice4_foodvalue = 15;
        public static int _juice4_watervalue = 25;
        public static string _juice4_ingredient1 = "FilteredWater";
        public static int _juice4_ingredient1amount = 1;
        public static string _juice4_ingredient2 = "CreepvinePiece";
        public static int _juice4_ingredient2amount = 1;
        public static string _juice4_ingredient3 = "None";
        public static int _juice4_ingredient3amount = 0;
        public static string _juice4_ingredient4 = "None";
        public static int _juice4_ingredient4amount = 0;
        public static string _juice4_ingredient5 = "None";
        public static int _juice4_ingredient5amount = 0;
        public static int _juice4_x = 1;
        public static int _juice4_y = 1;

        public static bool _cake1_enabled = true;
        public static string _cake1_name = "Peeper Cake";
        public static string _cake1_tooltip = "Coral Tube Sample mixed with a Peeper";
        public static int _cake1_foodvalue = 35;
        public static int _cake1_watervalue = 5;
        public static string _cake1_ingredient1 = "CoralChunk";
        public static int _cake1_ingredient1amount = 1;
        public static string _cake1_ingredient2 = "Peeper";
        public static int _cake1_ingredient2amount = 1;
        public static string _cake1_ingredient3 = "None";
        public static int _cake1_ingredient3amount = 0;
        public static string _cake1_ingredient4 = "None";
        public static int _cake1_ingredient4amount = 0;
        public static string _cake1_ingredient5 = "None";
        public static int _cake1_ingredient5amount = 0;
        public static int _cake1_x = 1;
        public static int _cake1_y = 1;

        public static bool _cake2_enabled = true;
        public static string _cake2_name = "Chinese Potato Cake";
        public static string _cake2_tooltip = "Coral Tube Sample mixed with a Chinese Potato";
        public static int _cake2_foodvalue = 40;
        public static int _cake2_watervalue = 5;
        public static string _cake2_ingredient1 = "CoralChunk";
        public static int _cake2_ingredient1amount = 1;
        public static string _cake2_ingredient2 = "PurpleVegetable";
        public static int _cake2_ingredient2amount = 1;
        public static string _cake2_ingredient3 = "None";
        public static int _cake2_ingredient3amount = 0;
        public static string _cake2_ingredient4 = "None";
        public static int _cake2_ingredient4amount = 0;
        public static string _cake2_ingredient5 = "None";
        public static int _cake2_ingredient5amount = 0;
        public static int _cake2_x = 1;
        public static int _cake2_y = 1;

        public static bool _cake3_enabled = true;
        public static string _cake3_name = "Bladderfish Cake";
        public static string _cake3_tooltip = "Coral Tube Sample mixed with a Bladderfish";
        public static int _cake3_foodvalue = 35;
        public static int _cake3_watervalue = 15;
        public static string _cake3_ingredient1 = "CoralChunk";
        public static int _cake3_ingredient1amount = 1;
        public static string _cake3_ingredient2 = "Bladderfish";
        public static int _cake3_ingredient2amount = 1;
        public static string _cake3_ingredient3 = "None";
        public static int _cake3_ingredient3amount = 0;
        public static string _cake3_ingredient4 = "None";
        public static int _cake3_ingredient4amount = 0;
        public static string _cake3_ingredient5 = "None";
        public static int _cake3_ingredient5amount = 0;
        public static int _cake3_x = 1;
        public static int _cake3_y = 1;

        public static bool _cake4_enabled = true;
        public static string _cake4_name = "Boomerang Cake";
        public static string _cake4_tooltip = "Coral Tube Sample mixed with a Boomerang";
        public static int _cake4_foodvalue = 30;
        public static int _cake4_watervalue = 10;
        public static string _cake4_ingredient1 = "CoralChunk";
        public static int _cake4_ingredient1amount = 1;
        public static string _cake4_ingredient2 = "Boomerang";
        public static int _cake4_ingredient2amount = 1;
        public static string _cake4_ingredient3 = "None";
        public static int _cake4_ingredient3amount = 0;
        public static string _cake4_ingredient4 = "None";
        public static int _cake4_ingredient4amount = 0;
        public static string _cake4_ingredient5 = "None";
        public static int _cake4_ingredient5amount = 0;
        public static int _cake4_x = 1;
        public static int _cake4_y = 1;

        /// <summary>
        /// Loads the config
        /// </summary>
        public static void Load()
        {
            try
            {
                Config.Load();
                var configChanged =

                  Config.TryGet(ref _debug, "Enable debugging")

                | Config.TryGet(ref _juice1_enabled, "Juices", "Juice1", "Enabled")
                | Config.TryGet(ref _juice1_name, "Juices", "Juice1", "Name")
                | Config.TryGet(ref _juice1_tooltip, "Juices", "Juice1", "Tooltip")
                | Config.TryGet(ref _juice1_foodvalue, "Juices", "Juice1", "Values", "Food")
                | Config.TryGet(ref _juice1_watervalue, "Juices", "Juice1", "Values", "Water")
                | Config.TryGet(ref _juice1_ingredient1, "Juices", "Juice1", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice1_ingredient1amount, "Juices", "Juice1", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice1_ingredient2, "Juices", "Juice1", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice1_ingredient2amount, "Juices", "Juice1", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice1_ingredient3, "Juices", "Juice1", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _juice1_ingredient3amount, "Juices", "Juice1", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _juice1_ingredient4, "Juices", "Juice1", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _juice1_ingredient4amount, "Juices", "Juice1", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _juice1_ingredient5, "Juices", "Juice1", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _juice1_ingredient5amount, "Juices", "Juice1", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _juice1_x, "Juices", "Juice1", "Size", "X")
                | Config.TryGet(ref _juice1_y, "Juices", "Juice1", "Size", "Y")

                | Config.TryGet(ref _juice2_enabled, "Juices", "Juice2", "Enabled")
                | Config.TryGet(ref _juice2_name, "Juices", "Juice2", "Name")
                | Config.TryGet(ref _juice2_tooltip, "Juices", "Juice2", "Tooltip")
                | Config.TryGet(ref _juice2_foodvalue, "Juices", "Juice2", "Values", "Food")
                | Config.TryGet(ref _juice2_watervalue, "Juices", "Juice2", "Values", "Water")
                | Config.TryGet(ref _juice2_ingredient1, "Juices", "Juice2", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice2_ingredient1amount, "Juices", "Juice2", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice2_ingredient2, "Juices", "Juice2", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice2_ingredient2amount, "Juices", "Juice2", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice2_ingredient3, "Juices", "Juice2", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _juice2_ingredient3amount, "Juices", "Juice2", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _juice2_ingredient4, "Juices", "Juice2", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _juice2_ingredient4amount, "Juices", "Juice2", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _juice2_ingredient5, "Juices", "Juice2", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _juice2_ingredient5amount, "Juices", "Juice2", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _juice2_x, "Juices", "Juice2", "Size", "X")
                | Config.TryGet(ref _juice2_y, "Juices", "Juice2", "Size", "Y")

                | Config.TryGet(ref _juice3_enabled, "Juices", "Juice3", "Enabled")
                | Config.TryGet(ref _juice3_name, "Juices", "Juice3", "Name")
                | Config.TryGet(ref _juice3_tooltip, "Juices", "Juice3", "Tooltip")
                | Config.TryGet(ref _juice3_foodvalue, "Juices", "Juice3", "Values", "Food")
                | Config.TryGet(ref _juice3_watervalue, "Juices", "Juice3", "Values", "Water")
                | Config.TryGet(ref _juice3_ingredient1, "Juices", "Juice3", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice3_ingredient1amount, "Juices", "Juice3", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice3_ingredient2, "Juices", "Juice3", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice3_ingredient2amount, "Juices", "Juice3", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice3_ingredient3, "Juices", "Juice3", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _juice3_ingredient3amount, "Juices", "Juice3", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _juice3_ingredient4, "Juices", "Juice3", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _juice3_ingredient4amount, "Juices", "Juice3", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _juice3_ingredient5, "Juices", "Juice3", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _juice3_ingredient5amount, "Juices", "Juice3", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _juice3_x, "Juices", "Juice3", "Size", "X")
                | Config.TryGet(ref _juice3_y, "Juices", "Juice3", "Size", "Y")

                | Config.TryGet(ref _juice4_enabled, "Juices", "Juice4", "Enabled")
                | Config.TryGet(ref _juice4_name, "Juices", "Juice4", "Name")
                | Config.TryGet(ref _juice4_tooltip, "Juices", "Juice4", "Tooltip")
                | Config.TryGet(ref _juice4_foodvalue, "Juices", "Juice4", "Values", "Food")
                | Config.TryGet(ref _juice4_watervalue, "Juices", "Juice4", "Values", "Water")
                | Config.TryGet(ref _juice4_ingredient1, "Juices", "Juice4", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice4_ingredient1amount, "Juices", "Juice4", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice4_ingredient2, "Juices", "Juice4", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice4_ingredient2amount, "Juices", "Juice4", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice4_ingredient3, "Juices", "Juice4", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _juice4_ingredient3amount, "Juices", "Juice4", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _juice4_ingredient4, "Juices", "Juice4", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _juice4_ingredient4amount, "Juices", "Juice4", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _juice4_ingredient5, "Juices", "Juice4", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _juice4_ingredient5amount, "Juices", "Juice4", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _juice4_x, "Juices", "Juice4", "Size", "X")
                | Config.TryGet(ref _juice4_y, "Juices", "Juice4", "Size", "Y")

                | Config.TryGet(ref _cake1_enabled, "Cakes", "Cake1", "Enabled")
                | Config.TryGet(ref _cake1_name, "Cakes", "Cake1", "Name")
                | Config.TryGet(ref _cake1_tooltip, "Cakes", "Cake1", "Tooltip")
                | Config.TryGet(ref _cake1_foodvalue, "Cakes", "Cake1", "Values", "Food")
                | Config.TryGet(ref _cake1_watervalue, "Cakes", "Cake1", "Values", "Water")
                | Config.TryGet(ref _cake1_ingredient1, "Cakes", "Cake1", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake1_ingredient1amount, "Cakes", "Cake1", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake1_ingredient2, "Cakes", "Cake1", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake1_ingredient2amount, "Cakes", "Cake1", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake1_ingredient3, "Cakes", "Cake1", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _cake1_ingredient3amount, "Cakes", "Cake1", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _cake1_ingredient4, "Cakes", "Cake1", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _cake1_ingredient4amount, "Cakes", "Cake1", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _cake1_ingredient5, "Cakes", "Cake1", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _cake1_ingredient5amount, "Cakes", "Cake1", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _cake1_x, "Cakes", "Cake1", "Size", "X")
                | Config.TryGet(ref _cake1_y, "Cakes", "Cake1", "Size", "Y")

                | Config.TryGet(ref _cake2_enabled, "Cakes", "Cake2", "Enabled")
                | Config.TryGet(ref _cake2_name, "Cakes", "Cake2", "Name")
                | Config.TryGet(ref _cake2_tooltip, "Cakes", "Cake2", "Tooltip")
                | Config.TryGet(ref _cake2_foodvalue, "Cakes", "Cake2", "Values", "Food")
                | Config.TryGet(ref _cake2_watervalue, "Cakes", "Cake2", "Values", "Water")
                | Config.TryGet(ref _cake2_ingredient1, "Cakes", "Cake2", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake2_ingredient1amount, "Cakes", "Cake2", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake2_ingredient2, "Cakes", "Cake2", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake2_ingredient2amount, "Cakes", "Cake2", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake2_ingredient3, "Cakes", "Cake2", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _cake2_ingredient3amount, "Cakes", "Cake2", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _cake2_ingredient4, "Cakes", "Cake2", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _cake2_ingredient4amount, "Cakes", "Cake2", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _cake2_ingredient5, "Cakes", "Cake2", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _cake2_ingredient5amount, "Cakes", "Cake2", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _cake2_x, "Cakes", "Cake2", "Size", "X")
                | Config.TryGet(ref _cake2_y, "Cakes", "Cake2", "Size", "Y")

                | Config.TryGet(ref _cake3_enabled, "Cakes", "Cake3", "Enabled")
                | Config.TryGet(ref _cake3_name, "Cakes", "Cake3", "Name")
                | Config.TryGet(ref _cake3_tooltip, "Cakes", "Cake3", "Tooltip")
                | Config.TryGet(ref _cake3_foodvalue, "Cakes", "Cake3", "Values", "Food")
                | Config.TryGet(ref _cake3_watervalue, "Cakes", "Cake3", "Values", "Water")
                | Config.TryGet(ref _cake3_ingredient1, "Cakes", "Cake3", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake3_ingredient1amount, "Cakes", "Cake3", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake3_ingredient2, "Cakes", "Cake3", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake3_ingredient2amount, "Cakes", "Cake3", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake3_ingredient3, "Cakes", "Cake3", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _cake3_ingredient3amount, "Cakes", "Cake3", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _cake3_ingredient4, "Cakes", "Cake3", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _cake3_ingredient4amount, "Cakes", "Cake3", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _cake3_ingredient5, "Cakes", "Cake3", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _cake3_ingredient5amount, "Cakes", "Cake3", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _cake3_x, "Cakes", "Cake3", "Size", "X")
                | Config.TryGet(ref _cake3_y, "Cakes", "Cake3", "Size", "Y")

                | Config.TryGet(ref _cake4_enabled, "Cakes", "Cake4", "Enabled")
                | Config.TryGet(ref _cake4_name, "Cakes", "Cake4", "Name")
                | Config.TryGet(ref _cake4_tooltip, "Cakes", "Cake4", "Tooltip")
                | Config.TryGet(ref _cake4_foodvalue, "Cakes", "Cake4", "Values", "Food")
                | Config.TryGet(ref _cake4_watervalue, "Cakes", "Cake4", "Values", "Water")
                | Config.TryGet(ref _cake4_ingredient1, "Cakes", "Cake4", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake4_ingredient1amount, "Cakes", "Cake4", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake4_ingredient2, "Cakes", "Cake4", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake4_ingredient2amount, "Cakes", "Cake4", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake4_ingredient3, "Cakes", "Cake4", "Ingredients", "Ingredient3", "Item")
                | Config.TryGet(ref _cake4_ingredient3amount, "Cakes", "Cake4", "Ingredients", "Ingredient3", "Amount")
                | Config.TryGet(ref _cake4_ingredient4, "Cakes", "Cake4", "Ingredients", "Ingredient4", "Item")
                | Config.TryGet(ref _cake4_ingredient4amount, "Cakes", "Cake4", "Ingredients", "Ingredient4", "Amount")
                | Config.TryGet(ref _cake4_ingredient5, "Cakes", "Cake4", "Ingredients", "Ingredient5", "Item")
                | Config.TryGet(ref _cake4_ingredient5amount, "Cakes", "Cake4", "Ingredients", "Ingredient5", "Amount")
                | Config.TryGet(ref _cake4_x, "Cakes", "Cake4", "Size", "X")
                | Config.TryGet(ref _cake4_y, "Cakes", "Cake4", "Size", "Y");
                
                if (configChanged)
                {
                    Log.Info("Config", "Some values are missing from the config, adding them now...");
                    Save("Config");
                    Log.Info("Config", "Missing values added");
                }
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
        /// <summary>
        /// Saves the config
        /// </summary>
        public static void Save()
        {
            try
            {
                Log.Debug("Saving config...");
                Config.Save();
                Log.Debug("Config saved");
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
        /// <summary>
        /// Saves the config with a prefix for debugging
        /// </summary>
        /// <param name="prefix">Prefix for debugging</param>
        public static void Save(string prefix)
        {
            try
            {
                Log.Debug("[" + prefix + "] " + "Saving config...");
                Config.Save();
                Log.Debug("[" + prefix + "] " + "Config saved");
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
        /// <summary>
        /// Initializes the config
        /// </summary>
        public static void Init()
        {
            try
            {
                Logger.ClearCustomLog();
                Load();
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}