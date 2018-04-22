﻿using System;
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

        public static TechType _ingredient1missing = TechTypePatcher.AddTechType("CustomFoodIngredient1Missing", "Ingredient1 Missing", "This should not be in your inventory");
        public static TechType _ingredient2missing = TechTypePatcher.AddTechType("CustomFoodIngredient2Missing", "Ingredient2 Missing", "This should not be in your inventory");

        public static bool _debug = false;

        public static Sprite juice_blue = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_blue.assets").LoadAsset<Sprite>("JuiceBlue");
        public static Sprite juice_bluegreen = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_bluegreen.assets").LoadAsset<Sprite>("JuiceBlueGreen");
        public static Sprite juice_green = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_green.assets").LoadAsset<Sprite>("JuiceGreen");
        public static Sprite juice_lightblue = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_lightblue.assets").LoadAsset<Sprite>("JuiceLightBlue");
        public static Sprite juice_orange = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_orange.assets").LoadAsset<Sprite>("JuiceOrange");
        public static Sprite juice_pink = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_pink.assets").LoadAsset<Sprite>("JuicePink");
        public static Sprite juice_purple = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_purple.assets").LoadAsset<Sprite>("JuicePurple");
        public static Sprite juice_red = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_red.assets").LoadAsset<Sprite>("JuiceRed");
        public static Sprite juice_yellow = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_yellow.assets").LoadAsset<Sprite>("JuiceYellow");
        public static Sprite juice_default = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/juice_default.assets").LoadAsset<Sprite>("JuiceDefault");

        public static Sprite cake_blue = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_blue.assets").LoadAsset<Sprite>("CakeBlue");
        public static Sprite cake_bluegreen = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_bluegreen.assets").LoadAsset<Sprite>("CakeBlueGreen");
        public static Sprite cake_green = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_green.assets").LoadAsset<Sprite>("CakeGreen");
        public static Sprite cake_lightblue = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_lightblue.assets").LoadAsset<Sprite>("CakeLightBlue");
        public static Sprite cake_orange = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_orange.assets").LoadAsset<Sprite>("CakeOrange");
        public static Sprite cake_pink = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_pink.assets").LoadAsset<Sprite>("CakePink");
        public static Sprite cake_purple = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_purple.assets").LoadAsset<Sprite>("CakePurple");
        public static Sprite cake_red = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_red.assets").LoadAsset<Sprite>("CakeRed");
        public static Sprite cake_yellow = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_yellow.assets").LoadAsset<Sprite>("CakeYellow");
        public static Sprite cake_default = AssetBundle.LoadFromFile(@"./QMods/CustomFood/Assets/cake_default.assets").LoadAsset<Sprite>("CakeDefault");

        public static string _tooltipsuffix = " - Added by the CustomFood mod.";

        public static bool _juice1_enabled = true;
        public static string _juice1_name = "Bulbo Tree Juice";
        public static string _juice1_tooltip = "Water mixed with a Bulbo Tree Sample";
        public static int _juice1_foodvalue = 30;
        public static int _juice1_watervalue = 40;
        public static string _juice1_ingredient1 = "FilteredWater";
        public static int _juice1_ingredient1amount = 1;
        public static string _juice1_ingredient2 = "BulboTreePiece";
        public static int _juice1_ingredient2amount = 1;
        public static int _juice1_x = 1;
        public static int _juice1_y = 1;
        public static string _juice1_sprite = "Default";

        public static bool _juice2_enabled = true;
        public static string _juice2_name = "Lantern Fruit Juice";
        public static string _juice2_tooltip = "Water mixed with a Lantern Fruit";
        public static int _juice2_foodvalue = 30;
        public static int _juice2_watervalue = 40;
        public static string _juice2_ingredient1 = "FilteredWater";
        public static int _juice2_ingredient1amount = 1;
        public static string _juice2_ingredient2 = "HangingFruit";
        public static int _juice2_ingredient2amount = 1;
        public static int _juice2_x = 1;
        public static int _juice2_y = 1;
        public static string _juice2_sprite = "Default";

        public static bool _juice3_enabled = true;
        public static string _juice3_name = "Marblemelon Juice";
        public static string _juice3_tooltip = "Water mixed with a Marblemelon";
        public static int _juice3_foodvalue = 30;
        public static int _juice3_watervalue = 40;
        public static string _juice3_ingredient1 = "FilteredWater";
        public static int _juice3_ingredient1amount = 1;
        public static string _juice3_ingredient2 = "Melon";
        public static int _juice3_ingredient2amount = 1;
        public static int _juice3_x = 1;
        public static int _juice3_y = 1;
        public static string _juice3_sprite = "Default";

        public static bool _juice4_enabled = true;
        public static string _juice4_name = "Creepvine Juice";
        public static string _juice4_tooltip = "Water mixed with a Creepvine Sample";
        public static int _juice4_foodvalue = 30;
        public static int _juice4_watervalue = 40;
        public static string _juice4_ingredient1 = "FilteredWater";
        public static int _juice4_ingredient1amount = 1;
        public static string _juice4_ingredient2 = "CreepvinePiece";
        public static int _juice4_ingredient2amount = 1;
        public static int _juice4_x = 1;
        public static int _juice4_y = 1;
        public static string _juice4_sprite = "Default";

        public static bool _juice5_enabled = true;
        public static string _juice5_name = "Gel Sack Juice";
        public static string _juice5_tooltip = "Water mixed with a Gel Sack";
        public static int _juice5_foodvalue = 30;
        public static int _juice5_watervalue = 40;
        public static string _juice5_ingredient1 = "FilteredWater";
        public static int _juice5_ingredient1amount = 1;
        public static string _juice5_ingredient2 = "JellyPlant";
        public static int _juice5_ingredient2amount = 1;
        public static int _juice5_x = 1;
        public static int _juice5_y = 1;
        public static string _juice5_sprite = "Default";

        public static bool _juice6_enabled = true;
        public static string _juice6_name = "Marblemelon Juice";
        public static string _juice6_tooltip = "Water mixed with a Bulb Bush Sample";
        public static int _juice6_foodvalue = 30;
        public static int _juice6_watervalue = 40;
        public static string _juice6_ingredient1 = "FilteredWater";
        public static int _juice6_ingredient1amount = 1;
        public static string _juice6_ingredient2 = "KooshChunk";
        public static int _juice6_ingredient2amount = 1;
        public static int _juice6_x = 1;
        public static int _juice6_y = 1;
        public static string _juice6_sprite = "Default";

        public static bool _cake1_enabled = true;
        public static string _cake1_name = "Peeper Cake";
        public static string _cake1_tooltip = "Coral Tube Sample mixed with a Peeper";
        public static int _cake1_foodvalue = 40;
        public static int _cake1_watervalue = 30;
        public static string _cake1_ingredient1 = "CoralChunk";
        public static int _cake1_ingredient1amount = 1;
        public static string _cake1_ingredient2 = "Peeper";
        public static int _cake1_ingredient2amount = 1;
        public static int _cake1_x = 1;
        public static int _cake1_y = 1;
        public static string _cake1_sprite = "Default";

        public static bool _cake2_enabled = true;
        public static string _cake2_name = "Chinese Potato Cake";
        public static string _cake2_tooltip = "Coral Tube Sample mixed with a Chinese Potato";
        public static int _cake2_foodvalue = 40;
        public static int _cake2_watervalue = 30;
        public static string _cake2_ingredient1 = "CoralChunk";
        public static int _cake2_ingredient1amount = 1;
        public static string _cake2_ingredient2 = "PurpleVegetable";
        public static int _cake2_ingredient2amount = 1;
        public static int _cake2_x = 1;
        public static int _cake2_y = 1;
        public static string _cake2_sprite = "Default";

        public static bool _cake3_enabled = true;
        public static string _cake3_name = "Bladderfish Cake";
        public static string _cake3_tooltip = "Coral Tube Sample mixed with a Bladderfish";
        public static int _cake3_foodvalue = 40;
        public static int _cake3_watervalue = 30;
        public static string _cake3_ingredient1 = "CoralChunk";
        public static int _cake3_ingredient1amount = 1;
        public static string _cake3_ingredient2 = "Bladderfish";
        public static int _cake3_ingredient2amount = 1;
        public static int _cake3_x = 1;
        public static int _cake3_y = 1;
        public static string _cake3_sprite = "Default";

        public static bool _cake4_enabled = true;
        public static string _cake4_name = "Boomerang Cake";
        public static string _cake4_tooltip = "Coral Tube Sample mixed with a Boomerang";
        public static int _cake4_foodvalue = 40;
        public static int _cake4_watervalue = 30;
        public static string _cake4_ingredient1 = "CoralChunk";
        public static int _cake4_ingredient1amount = 1;
        public static string _cake4_ingredient2 = "Boomerang";
        public static int _cake4_ingredient2amount = 1;
        public static int _cake4_x = 1;
        public static int _cake4_y = 1;
        public static string _cake4_sprite = "Default";

        public static bool _cake5_enabled = true;
        public static string _cake5_name = "Hoverfish Cake";
        public static string _cake5_tooltip = "Coral Tube Sample mixed with a Hoverfish";
        public static int _cake5_foodvalue = 40;
        public static int _cake5_watervalue = 30;
        public static string _cake5_ingredient1 = "CoralChunk";
        public static int _cake5_ingredient1amount = 1;
        public static string _cake5_ingredient2 = "Hoverfish";
        public static int _cake5_ingredient2amount = 1;
        public static int _cake5_x = 1;
        public static int _cake5_y = 1;
        public static string _cake5_sprite = "Default";

        public static bool _cake6_enabled = true;
        public static string _cake6_name = "Spadefish Cake";
        public static string _cake6_tooltip = "Coral Tube Sample mixed with a Spadefish";
        public static int _cake6_foodvalue = 40;
        public static int _cake6_watervalue = 30;
        public static string _cake6_ingredient1 = "CoralChunk";
        public static int _cake6_ingredient1amount = 1;
        public static string _cake6_ingredient2 = "Spadefish";
        public static int _cake6_ingredient2amount = 1;
        public static int _cake6_x = 1;
        public static int _cake6_y = 1;
        public static string _cake6_sprite = "Default";

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
                | Config.TryGet(ref _juice1_x, "Juices", "Juice1", "Size", "X")
                | Config.TryGet(ref _juice1_y, "Juices", "Juice1", "Size", "Y")
                | Config.TryGet(ref _juice1_sprite, "Juices", "Juice1", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")


                | Config.TryGet(ref _juice2_enabled, "Juices", "Juice2", "Enabled")
                | Config.TryGet(ref _juice2_name, "Juices", "Juice2", "Name")
                | Config.TryGet(ref _juice2_tooltip, "Juices", "Juice2", "Tooltip")
                | Config.TryGet(ref _juice2_foodvalue, "Juices", "Juice2", "Values", "Food")
                | Config.TryGet(ref _juice2_watervalue, "Juices", "Juice2", "Values", "Water")
                | Config.TryGet(ref _juice2_ingredient1, "Juices", "Juice2", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice2_ingredient1amount, "Juices", "Juice2", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice2_ingredient2, "Juices", "Juice2", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice2_ingredient2amount, "Juices", "Juice2", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice2_x, "Juices", "Juice2", "Size", "X")
                | Config.TryGet(ref _juice2_y, "Juices", "Juice2", "Size", "Y")
                | Config.TryGet(ref _juice2_sprite, "Juices", "Juice2", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _juice3_enabled, "Juices", "Juice3", "Enabled")
                | Config.TryGet(ref _juice3_name, "Juices", "Juice3", "Name")
                | Config.TryGet(ref _juice3_tooltip, "Juices", "Juice3", "Tooltip")
                | Config.TryGet(ref _juice3_foodvalue, "Juices", "Juice3", "Values", "Food")
                | Config.TryGet(ref _juice3_watervalue, "Juices", "Juice3", "Values", "Water")
                | Config.TryGet(ref _juice3_ingredient1, "Juices", "Juice3", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice3_ingredient1amount, "Juices", "Juice3", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice3_ingredient2, "Juices", "Juice3", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice3_ingredient2amount, "Juices", "Juice3", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice3_x, "Juices", "Juice3", "Size", "X")
                | Config.TryGet(ref _juice3_y, "Juices", "Juice3", "Size", "Y")
                | Config.TryGet(ref _juice3_sprite, "Juices", "Juice3", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _juice4_enabled, "Juices", "Juice4", "Enabled")
                | Config.TryGet(ref _juice4_name, "Juices", "Juice4", "Name")
                | Config.TryGet(ref _juice4_tooltip, "Juices", "Juice4", "Tooltip")
                | Config.TryGet(ref _juice4_foodvalue, "Juices", "Juice4", "Values", "Food")
                | Config.TryGet(ref _juice4_watervalue, "Juices", "Juice4", "Values", "Water")
                | Config.TryGet(ref _juice4_ingredient1, "Juices", "Juice4", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice4_ingredient1amount, "Juices", "Juice4", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice4_ingredient2, "Juices", "Juice4", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice4_ingredient2amount, "Juices", "Juice4", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice4_x, "Juices", "Juice4", "Size", "X")
                | Config.TryGet(ref _juice4_y, "Juices", "Juice4", "Size", "Y")
                | Config.TryGet(ref _juice4_sprite, "Juices", "Juice4", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _juice5_enabled, "Juices", "Juice5", "Enabled")
                | Config.TryGet(ref _juice5_name, "Juices", "Juice5", "Name")
                | Config.TryGet(ref _juice5_tooltip, "Juices", "Juice5", "Tooltip")
                | Config.TryGet(ref _juice5_foodvalue, "Juices", "Juice5", "Values", "Food")
                | Config.TryGet(ref _juice5_watervalue, "Juices", "Juice5", "Values", "Water")
                | Config.TryGet(ref _juice5_ingredient1, "Juices", "Juice5", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice5_ingredient1amount, "Juices", "Juice5", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice5_ingredient2, "Juices", "Juice5", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice5_ingredient2amount, "Juices", "Juice5", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice5_x, "Juices", "Juice5", "Size", "X")
                | Config.TryGet(ref _juice5_y, "Juices", "Juice5", "Size", "Y")
                | Config.TryGet(ref _juice5_sprite, "Juices", "Juice5", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _juice6_enabled, "Juices", "Juice6", "Enabled")
                | Config.TryGet(ref _juice6_name, "Juices", "Juice6", "Name")
                | Config.TryGet(ref _juice6_tooltip, "Juices", "Juice6", "Tooltip")
                | Config.TryGet(ref _juice6_foodvalue, "Juices", "Juice6", "Values", "Food")
                | Config.TryGet(ref _juice6_watervalue, "Juices", "Juice6", "Values", "Water")
                | Config.TryGet(ref _juice6_ingredient1, "Juices", "Juice6", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _juice6_ingredient1amount, "Juices", "Juice6", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _juice6_ingredient2, "Juices", "Juice6", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _juice6_ingredient2amount, "Juices", "Juice6", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _juice6_x, "Juices", "Juice6", "Size", "X")
                | Config.TryGet(ref _juice6_y, "Juices", "Juice6", "Size", "Y")
                | Config.TryGet(ref _juice6_sprite, "Juices", "Juice6", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _cake1_enabled, "Cakes", "Cake1", "Enabled")
                | Config.TryGet(ref _cake1_name, "Cakes", "Cake1", "Name")
                | Config.TryGet(ref _cake1_tooltip, "Cakes", "Cake1", "Tooltip")
                | Config.TryGet(ref _cake1_foodvalue, "Cakes", "Cake1", "Values", "Food")
                | Config.TryGet(ref _cake1_watervalue, "Cakes", "Cake1", "Values", "Water")
                | Config.TryGet(ref _cake1_ingredient1, "Cakes", "Cake1", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake1_ingredient1amount, "Cakes", "Cake1", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake1_ingredient2, "Cakes", "Cake1", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake1_ingredient2amount, "Cakes", "Cake1", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake1_x, "Cakes", "Cake1", "Size", "X")
                | Config.TryGet(ref _cake1_y, "Cakes", "Cake1", "Size", "Y")
                | Config.TryGet(ref _cake1_sprite, "Cakes", "Cake1", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _cake2_enabled, "Cakes", "Cake2", "Enabled")
                | Config.TryGet(ref _cake2_name, "Cakes", "Cake2", "Name")
                | Config.TryGet(ref _cake2_tooltip, "Cakes", "Cake2", "Tooltip")
                | Config.TryGet(ref _cake2_foodvalue, "Cakes", "Cake2", "Values", "Food")
                | Config.TryGet(ref _cake2_watervalue, "Cakes", "Cake2", "Values", "Water")
                | Config.TryGet(ref _cake2_ingredient1, "Cakes", "Cake2", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake2_ingredient1amount, "Cakes", "Cake2", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake2_ingredient2, "Cakes", "Cake2", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake2_ingredient2amount, "Cakes", "Cake2", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake2_x, "Cakes", "Cake2", "Size", "X")
                | Config.TryGet(ref _cake2_y, "Cakes", "Cake2", "Size", "Y")
                | Config.TryGet(ref _cake2_sprite, "Cakes", "Cake2", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _cake3_enabled, "Cakes", "Cake3", "Enabled")
                | Config.TryGet(ref _cake3_name, "Cakes", "Cake3", "Name")
                | Config.TryGet(ref _cake3_tooltip, "Cakes", "Cake3", "Tooltip")
                | Config.TryGet(ref _cake3_foodvalue, "Cakes", "Cake3", "Values", "Food")
                | Config.TryGet(ref _cake3_watervalue, "Cakes", "Cake3", "Values", "Water")
                | Config.TryGet(ref _cake3_ingredient1, "Cakes", "Cake3", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake3_ingredient1amount, "Cakes", "Cake3", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake3_ingredient2, "Cakes", "Cake3", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake3_ingredient2amount, "Cakes", "Cake3", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake3_x, "Cakes", "Cake3", "Size", "X")
                | Config.TryGet(ref _cake3_y, "Cakes", "Cake3", "Size", "Y")
                | Config.TryGet(ref _cake3_sprite, "Cakes", "Cake3", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _cake4_enabled, "Cakes", "Cake4", "Enabled")
                | Config.TryGet(ref _cake4_name, "Cakes", "Cake4", "Name")
                | Config.TryGet(ref _cake4_tooltip, "Cakes", "Cake4", "Tooltip")
                | Config.TryGet(ref _cake4_foodvalue, "Cakes", "Cake4", "Values", "Food")
                | Config.TryGet(ref _cake4_watervalue, "Cakes", "Cake4", "Values", "Water")
                | Config.TryGet(ref _cake4_ingredient1, "Cakes", "Cake4", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake4_ingredient1amount, "Cakes", "Cake4", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake4_ingredient2, "Cakes", "Cake4", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake4_ingredient2amount, "Cakes", "Cake4", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake4_x, "Cakes", "Cake4", "Size", "X")
                | Config.TryGet(ref _cake4_y, "Cakes", "Cake4", "Size", "Y")
                | Config.TryGet(ref _cake4_sprite, "Cakes", "Cake4", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _cake5_enabled, "Cakes", "Cake5", "Enabled")
                | Config.TryGet(ref _cake5_name, "Cakes", "Cake5", "Name")
                | Config.TryGet(ref _cake5_tooltip, "Cakes", "Cake5", "Tooltip")
                | Config.TryGet(ref _cake5_foodvalue, "Cakes", "Cake5", "Values", "Food")
                | Config.TryGet(ref _cake5_watervalue, "Cakes", "Cake5", "Values", "Water")
                | Config.TryGet(ref _cake5_ingredient1, "Cakes", "Cake5", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake5_ingredient1amount, "Cakes", "Cake5", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake5_ingredient2, "Cakes", "Cake5", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake5_ingredient2amount, "Cakes", "Cake5", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake5_x, "Cakes", "Cake5", "Size", "X")
                | Config.TryGet(ref _cake5_y, "Cakes", "Cake5", "Size", "Y")
                | Config.TryGet(ref _cake5_sprite, "Cakes", "Cake5", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'")

                | Config.TryGet(ref _cake6_enabled, "Cakes", "Cake6", "Enabled")
                | Config.TryGet(ref _cake6_name, "Cakes", "Cake6", "Name")
                | Config.TryGet(ref _cake6_tooltip, "Cakes", "Cake6", "Tooltip")
                | Config.TryGet(ref _cake6_foodvalue, "Cakes", "Cake6", "Values", "Food")
                | Config.TryGet(ref _cake6_watervalue, "Cakes", "Cake6", "Values", "Water")
                | Config.TryGet(ref _cake6_ingredient1, "Cakes", "Cake6", "Ingredients", "Ingredient1", "Item")
                | Config.TryGet(ref _cake6_ingredient1amount, "Cakes", "Cake6", "Ingredients", "Ingredient1", "Amount")
                | Config.TryGet(ref _cake6_ingredient2, "Cakes", "Cake6", "Ingredients", "Ingredient2", "Item")
                | Config.TryGet(ref _cake6_ingredient2amount, "Cakes", "Cake6", "Ingredients", "Ingredient2", "Amount")
                | Config.TryGet(ref _cake6_x, "Cakes", "Cake6", "Size", "X")
                | Config.TryGet(ref _cake6_y, "Cakes", "Cake6", "Size", "Y")
                | Config.TryGet(ref _cake6_sprite, "Cakes", "Cake6", "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'");

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