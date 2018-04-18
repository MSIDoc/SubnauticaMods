using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using Harmony;
using SMLHelper;
using SMLHelper.Patchers;
using UnityEngine;
using Utilites.Config;
using Logger = Utilites.Logger.Logger;
using LogType = Utilites.Logger.LogType;
using LogLevel = Utilites.Logger.LogLevel;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Oculus.Newtonsoft.Json;
using System.IO;
using UWE;
using Microsoft.CSharp;

namespace CustomFood
{
    /// <summary>
    /// Main class for loading or saving the config
    /// </summary>
    public class Cfg
    {
        public static readonly ConfigFile Config = new ConfigFile("config");
 
        public static Atlas.Sprite JuiceSprite = SpriteManager.Get(TechType.FilteredWater);
        public static Atlas.Sprite CakesSprite = SpriteManager.Get(TechType.NutrientBlock);

        public static bool _debug = false;

        public static string _tooltipsuffix = " Added by the CustomFood mod";

        public static bool _juicenabled = true;
        public static bool _cakeenabled = true;

        public static string _juice1_tooltip = "Juice1";
        public static string _juice2_tooltip = "Juice2";
        public static string _juice3_tooltip = "Juice3";
        public static string _juice4_tooltip = "Juice4";
        public static string _juice5_tooltip = "Juice5";
        public static string _juice6_tooltip = "Juice6";
        public static string _cake1_tooltip = "Cake1";
        public static string _cake2_tooltip = "Cake2";
        public static string _cake3_tooltip = "Cake3";
        public static string _cake4_tooltip = "Cake4";
        public static string _cake5_tooltip = "Cake5";
        public static string _cake6_tooltip = "Cake6";

        public static string _juice1_namehere = "namehere1";
        public static string _juice1_ingredient1 = "FilteredWater";
        public static int _juice1_ingredient1amount = 1;
        public static string _juice1_ingredient2 = "BulboTreePiece";
        public static int _juice1_ingredient2amount = 1;
        public static int _juice1_foodvalue = 1;
        public static int _juice1_watervalue = 1;
        public static string _juice2_namehere = "namehere2";
        public static string _juice2_ingredient1 = "FilteredWater";
        public static int _juice2_ingredient1amount = 1;
        public static string _juice2_ingredient2 = "HangingFruit";
        public static int _juice2_ingredient2amount = 1;
        public static int _juice2_foodvalue = 1;
        public static int _juice2_watervalue = 1;
        public static string _juice3_namehere = "namehere3";
        public static string _juice3_ingredient1 = "FilteredWater";
        public static int _juice3_ingredient1amount = 1;
        public static string _juice3_ingredient2 = "Melon";
        public static int _juice3_ingredient2amount = 1;
        public static int _juice3_foodvalue = 1;
        public static int _juice3_watervalue = 1;
        public static string _juice4_namehere = "namehere4";
        public static string _juice4_ingredient1 = "FilteredWater";
        public static int _juice4_ingredient1amount = 1;
        public static string _juice4_ingredient2 = "CreepvinePiece";
        public static int _juice4_ingredient2amount = 1;
        public static int _juice4_foodvalue = 1;
        public static int _juice4_watervalue = 1;
        public static string _juice5_namehere = "namehere5";
        public static string _juice5_ingredient1 = "FilteredWater";
        public static int _juice5_ingredient1amount = 1;
        public static string _juice5_ingredient2 = "JellyPlant";
        public static int _juice5_ingredient2amount = 1;
        public static int _juice5_foodvalue = 1;
        public static int _juice5_watervalue = 1;
        public static string _juice6_namehere = "namehere6";
        public static string _juice6_ingredient1 = "FilteredWater";
        public static int _juice6_ingredient1amount = 1;
        public static string _juice6_ingredient2 = "KooshChunk";
        public static int _juice6_ingredient2amount = 1;
        public static int _juice6_foodvalue = 1;
        public static int _juice6_watervalue = 1;

        public static string _cake1_namehere = "namehere1";
        public static string _cake1_ingredient1 = "CoralChunk";
        public static int _cake1_ingredient1amount = 1;
        public static string _cake1_ingredient2 = "Peeper";
        public static int _cake1_ingredient2amount = 1;
        public static int _cake1_foodvalue = 1;
        public static int _cake1_watervalue = 1;
        public static string _cake2_namehere = "namehere2";
        public static string _cake2_ingredient1 = "CoralChunk";
        public static int _cake2_ingredient1amount = 1;
        public static string _cake2_ingredient2 = "PurpleVegetable";
        public static int _cake2_ingredient2amount = 1;
        public static int _cake2_foodvalue = 1;
        public static int _cake2_watervalue = 1;
        public static string _cake3_namehere = "namehere3";
        public static string _cake3_ingredient1 = "CoralChunk";
        public static int _cake3_ingredient1amount = 1;
        public static string _cake3_ingredient2 = "Bladderfish";
        public static int _cake3_ingredient2amount = 1;
        public static int _cake3_foodvalue = 1;
        public static int _cake3_watervalue = 1;
        public static string _cake4_namehere = "namehere4";
        public static string _cake4_ingredient1 = "CoralChunk";
        public static int _cake4_ingredient1amount = 1;
        public static string _cake4_ingredient2 = "Boomerang";
        public static int _cake4_ingredient2amount = 1;
        public static int _cake4_foodvalue = 1;
        public static int _cake4_watervalue = 1;
        public static string _cake5_namehere = "namehere5";
        public static string _cake5_ingredient1 = "CoralChunk";
        public static int _cake5_ingredient1amount = 1;
        public static string _cake5_ingredient2 = "Hoverfish";
        public static int _cake5_ingredient2amount = 1;
        public static int _cake5_foodvalue = 1;
        public static int _cake5_watervalue = 1;
        public static string _cake6_namehere = "namehere6";
        public static string _cake6_ingredient1 = "CoralChunk";
        public static int _cake6_ingredient1amount = 1;
        public static string _cake6_ingredient2 = "Spadefish";
        public static int _cake6_ingredient2amount = 1;
        public static int _cake6_foodvalue = 1;
        public static int _cake6_watervalue = 1;

        public static void Load()
        {
            try
            {
                Config.Load();
                var configChanged =
                Config.TryGet(ref _juicenabled, "JuicesEnabled")
                | Config.TryGet(ref _cakeenabled, "CakesEnabled")
                | Config.TryGet(ref _juice1_tooltip, "Juice1", "Tooltip")
                | Config.TryGet(ref _juice1_namehere, "Juice1", "NameHere")
                | Config.TryGet(ref _juice1_foodvalue, "Juice1", "foodvalue")
                | Config.TryGet(ref _juice1_watervalue, "Juice1", "watervalue")
                | Config.TryGet(ref _juice1_ingredient1, "Juice1", "Ingredient1", "Item")
                | Config.TryGet(ref _juice1_ingredient1amount, "Juice1", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice1_ingredient2, "Juice1", "Ingredient2", "Item")
                | Config.TryGet(ref _juice1_ingredient2amount, "Juice1", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice2_tooltip, "Juice2", "Tooltip")
                | Config.TryGet(ref _juice2_namehere, "Juice2", "NameHere")
                | Config.TryGet(ref _juice2_foodvalue, "Juice2", "foodvalue")
                | Config.TryGet(ref _juice2_watervalue, "Juice2", "watervalue")
                | Config.TryGet(ref _juice2_ingredient1, "Juice2", "Ingredient1", "Item")
                | Config.TryGet(ref _juice2_ingredient1amount, "Juice2", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice2_ingredient2, "Juice2", "Ingredient2", "Item")
                | Config.TryGet(ref _juice2_ingredient2amount, "Juice2", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice3_tooltip, "Juice3", "Tooltip")
                | Config.TryGet(ref _juice3_namehere, "Juice3", "NameHere")
                | Config.TryGet(ref _juice3_foodvalue, "Juice3", "foodvalue")
                | Config.TryGet(ref _juice3_watervalue, "Juice3", "watervalue")
                | Config.TryGet(ref _juice3_ingredient1, "Juice3", "Ingredient1", "Item")
                | Config.TryGet(ref _juice3_ingredient1amount, "Juice3", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice3_ingredient2, "Juice3", "Ingredient2", "Item")
                | Config.TryGet(ref _juice3_ingredient2amount, "Juice3", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice4_tooltip, "Juice4", "Tooltip")
                | Config.TryGet(ref _juice4_namehere, "Juice4", "NameHere")
                | Config.TryGet(ref _juice4_foodvalue, "Juice4", "foodvalue")
                | Config.TryGet(ref _juice4_watervalue, "Juice4", "watervalue")
                | Config.TryGet(ref _juice4_ingredient1, "Juice4", "Ingredient1", "Item")
                | Config.TryGet(ref _juice4_ingredient1amount, "Juice4", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice4_ingredient2, "Juice4", "Ingredient2", "Item")
                | Config.TryGet(ref _juice4_ingredient2amount, "Juice4", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice5_tooltip, "Juice5", "Tooltip")
                | Config.TryGet(ref _juice5_namehere, "Juice5", "NameHere")
                | Config.TryGet(ref _juice5_foodvalue, "Juice5", "foodvalue")
                | Config.TryGet(ref _juice5_watervalue, "Juice5", "watervalue")
                | Config.TryGet(ref _juice5_ingredient1, "Juice5", "Ingredient1", "Item")
                | Config.TryGet(ref _juice5_ingredient1amount, "Juice5", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice5_ingredient2, "Juice5", "Ingredient2", "Item")
                | Config.TryGet(ref _juice5_ingredient2amount, "Juice5", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice6_tooltip, "Juice6", "Tooltip")
                | Config.TryGet(ref _juice6_namehere, "Juice6", "NameHere")
                | Config.TryGet(ref _juice6_foodvalue, "Juice6", "foodvalue")
                | Config.TryGet(ref _juice6_watervalue, "Juice6", "watervalue")
                | Config.TryGet(ref _juice6_ingredient1, "Juice6", "Ingredient1", "Item")
                | Config.TryGet(ref _juice6_ingredient1amount, "Juice6", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice6_ingredient2, "Juice6", "Ingredient2", "Item")
                | Config.TryGet(ref _juice6_ingredient2amount, "Juice6", "Ingredient2", "Amount")
                
                | Config.TryGet(ref _cake1_tooltip, "Cake1", "Tooltip")
                | Config.TryGet(ref _cake1_namehere, "Cake1", "NameHere")
                | Config.TryGet(ref _cake1_foodvalue, "Cake1", "foodvalue")
                | Config.TryGet(ref _cake1_watervalue, "Cake1", "watervalue")
                | Config.TryGet(ref _cake1_ingredient1, "Cake1", "Ingredient1", "Item")
                | Config.TryGet(ref _cake1_ingredient1amount, "Cake1", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake1_ingredient2, "Cake1", "Ingredient2", "Item")
                | Config.TryGet(ref _cake1_ingredient2amount, "Cake1", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake2_tooltip, "Cake2", "Tooltip")
                | Config.TryGet(ref _cake2_namehere, "Cake2", "NameHere")
                | Config.TryGet(ref _cake2_foodvalue, "Cake2", "foodvalue")
                | Config.TryGet(ref _cake2_watervalue, "Cake2", "watervalue")
                | Config.TryGet(ref _cake2_ingredient1, "Cake2", "Ingredient1", "Item")
                | Config.TryGet(ref _cake2_ingredient1amount, "Cake2", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake2_ingredient2, "Cake2", "Ingredient2", "Item")
                | Config.TryGet(ref _cake2_ingredient2amount, "Cake2", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake3_tooltip, "Cake3", "Tooltip")
                | Config.TryGet(ref _cake3_namehere, "Cake3", "NameHere")
                | Config.TryGet(ref _cake3_foodvalue, "Cake3", "foodvalue")
                | Config.TryGet(ref _cake3_watervalue, "Cake3", "watervalue")
                | Config.TryGet(ref _cake3_ingredient1, "Cake3", "Ingredient1", "Item")
                | Config.TryGet(ref _cake3_ingredient1amount, "Cake3", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake3_ingredient2, "Cake3", "Ingredient2", "Item")
                | Config.TryGet(ref _cake3_ingredient2amount, "Cake3", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake4_tooltip, "Cake4", "Tooltip")
                | Config.TryGet(ref _cake4_namehere, "Cake4", "NameHere")
                | Config.TryGet(ref _cake4_foodvalue, "Cake4", "foodvalue")
                | Config.TryGet(ref _cake4_watervalue, "Cake4", "watervalue")
                | Config.TryGet(ref _cake4_ingredient1, "Cake4", "Ingredient1", "Item")
                | Config.TryGet(ref _cake4_ingredient1amount, "Cake4", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake4_ingredient2, "Cake4", "Ingredient2", "Item")
                | Config.TryGet(ref _cake4_ingredient2amount, "Cake4", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake5_tooltip, "Cake5", "Tooltip")
                | Config.TryGet(ref _cake5_namehere, "Cake5", "NameHere")
                | Config.TryGet(ref _cake5_foodvalue, "Cake5", "foodvalue")
                | Config.TryGet(ref _cake5_watervalue, "Cake5", "watervalue")
                | Config.TryGet(ref _cake5_ingredient1, "Cake5", "Ingredient1", "Item")
                | Config.TryGet(ref _cake5_ingredient1amount, "Cake5", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake5_ingredient2, "Cake5", "Ingredient2", "Item")
                | Config.TryGet(ref _cake5_ingredient2amount, "Cake5", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake6_tooltip, "Cake6", "Tooltip")
                | Config.TryGet(ref _cake6_namehere, "Cake6", "NameHere")
                | Config.TryGet(ref _cake6_foodvalue, "Cake6", "foodvalue")
                | Config.TryGet(ref _cake6_watervalue, "Cake6", "watervalue")
                | Config.TryGet(ref _cake6_ingredient1, "Cake6", "Ingredient1", "Item")
                | Config.TryGet(ref _cake6_ingredient1amount, "Cake6", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake6_ingredient2, "Cake6", "Ingredient2", "Item")
                | Config.TryGet(ref _cake6_ingredient2amount, "Cake6", "Ingredient2", "Amount");
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
