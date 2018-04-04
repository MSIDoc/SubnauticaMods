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
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Oculus.Newtonsoft.Json;
using System.IO;
using UWE;
using Microsoft.CSharp;

namespace CustomFood
{
    public class QPatch
    {
        private static readonly ConfigFile Config = new ConfigFile("config");
        private static bool _juicenabled = true;
        private static bool _cakeenabled = true;

        private static string _juice1_namehere = "namehere1";
        private static int _juice1_foodvalue = 1;
        private static int _juice1_watervalue = 1;
        private static string _juice2_namehere = "namehere2";
        private static int _juice2_foodvalue = 1;
        private static int _juice2_watervalue = 1;
        private static string _juice3_namehere = "namehere3";
        private static int _juice3_foodvalue = 1;
        private static int _juice3_watervalue = 1;
        private static string _juice4_namehere = "namehere4";
        private static int _juice4_foodvalue = 1;
        private static int _juice4_watervalue = 1;
        private static string _juice5_namehere = "namehere5";
        private static int _juice5_foodvalue = 1;
        private static int _juice5_watervalue = 1;
        private static string _juice6_namehere = "namehere6";
        private static int _juice6_foodvalue = 1;
        private static int _juice6_watervalue = 1;

        private static string _cake1_namehere = "namehere1";
        private static int _cake1_foodvalue = 1;
        private static int _cake1_watervalue = 1;
        private static string _cake2_namehere = "namehere2";
        private static int _cake2_foodvalue = 1;
        private static int _cake2_watervalue = 1;
        private static string _cake3_namehere = "namehere3";
        private static int _cake3_foodvalue = 1;
        private static int _cake3_watervalue = 1;
        private static string _cake4_namehere = "namehere4";
        private static int _cake4_foodvalue = 1;
        private static int _cake4_watervalue = 1;


        public static AssetBundle AssetBundle;
        public const string CUSTOM_JUICE_1_ITEM_ID = "CustomJuice1";
        public static string CUSTOM_JUICE_1_PREFABPATH = "WorldEntities/Food/juice1";
        public static TechType CustomJuice1TechType;

        public const string CUSTOM_JUICE_2_ITEM_ID = "CustomJuice2";
        public static string CUSTOM_JUICE_2_PREFABPATH = "WorldEntities/Food/juice2";
        public static TechType CustomJuice2TechType;

        public const string CUSTOM_JUICE_3_ITEM_ID = "CustomJuice3";
        public static string CUSTOM_JUICE_3_PREFABPATH = "WorldEntities/Food/juice3";
        public static TechType CustomJuice3TechType;

        public const string CUSTOM_JUICE_4_ITEM_ID = "CustomJuice4";
        public static string CUSTOM_JUICE_4_PREFABPATH = "WorldEntities/Food/juice4";
        public static TechType CustomJuice4TechType;

        public const string CUSTOM_JUICE_5_ITEM_ID = "CustomJuice5";
        public static string CUSTOM_JUICE_5_PREFABPATH = "WorldEntities/Food/juice5";
        public static TechType CustomJuice5TechType;

        public const string CUSTOM_JUICE_6_ITEM_ID = "CustomJuice6";
        public static string CUSTOM_JUICE_6_PREFABPATH = "WorldEntities/Food/juice6";
        public static TechType CustomJuice6TechType;

        public const string CUSTOM_CAKE_1_ITEM_ID = "CustomCake1";
        public static string CUSTOM_CAKE_1_PREFABPATH = "WorldEntities/Food/CustomCake1";
        public static TechType CustomCake1TechType;

        public const string CUSTOM_CAKE_2_ITEM_ID = "CustomCake2";
        public static string CUSTOM_CAKE_2_PREFABPATH = "WorldEntities/Food/CustomCake2";
        public static TechType CustomCake2TechType;

        public const string CUSTOM_CAKE_3_ITEM_ID = "CustomCake3";
        public static string CUSTOM_CAKE_3_PREFABPATH = "WorldEntities/Food/CustomCake3";
        public static TechType CustomCake3TechType;

        public const string CUSTOM_CAKE_4_ITEM_ID = "CustomCake4";
        public static string CUSTOM_CAKE_4_PREFABPATH = "WorldEntities/Food/CustomCake4";
        public static TechType CustomCake4TechType;

        public static string filePath = @"./QMods/CustomFood/Config.json";

        public static void Patch()
        {
            Config.Load();
            var configChanged =
            Config.TryGet(ref _juicenabled, "JuicesEnabled")
            | Config.TryGet(ref _cakeenabled, "CakesEnabled")
            | Config.TryGet(ref _juice1_namehere, "Juice1", "NameHere")
            | Config.TryGet(ref _juice1_foodvalue, "Juice1", "foodvalue")
            | Config.TryGet(ref _juice1_watervalue, "Juice1", "watervalue")
            | Config.TryGet(ref _juice2_namehere, "Juice2", "NameHere")
            | Config.TryGet(ref _juice2_foodvalue, "Juice2", "foodvalue")
            | Config.TryGet(ref _juice2_watervalue, "Juice2", "watervalue")
            | Config.TryGet(ref _juice3_namehere, "Juice3", "NameHere")
            | Config.TryGet(ref _juice3_foodvalue, "Juice3", "foodvalue")
            | Config.TryGet(ref _juice3_watervalue, "Juice3", "watervalue")
            | Config.TryGet(ref _juice4_namehere, "Juice4", "NameHere")
            | Config.TryGet(ref _juice4_foodvalue, "Juice4", "foodvalue")
            | Config.TryGet(ref _juice4_watervalue, "Juice4", "watervalue")
            | Config.TryGet(ref _juice5_namehere, "Juice5", "NameHere")
            | Config.TryGet(ref _juice5_foodvalue, "Juice5", "foodvalue")
            | Config.TryGet(ref _juice5_watervalue, "Juice5", "watervalue")
            | Config.TryGet(ref _juice6_namehere, "Juice6", "NameHere")
            | Config.TryGet(ref _juice6_foodvalue, "Juice4", "foodvalue")
            | Config.TryGet(ref _juice6_watervalue, "Juice6", "watervalue")
            | Config.TryGet(ref _cake1_namehere, "Cake1", "NameHere")
            | Config.TryGet(ref _cake1_foodvalue, "Cake1", "foodvalue")
            | Config.TryGet(ref _cake1_watervalue, "Cake1", "watervalue")
            | Config.TryGet(ref _cake2_namehere, "Cake2", "NameHere")
            | Config.TryGet(ref _cake2_foodvalue, "Cake2", "foodvalue")
            | Config.TryGet(ref _cake2_watervalue, "Cake2", "watervalue")
            | Config.TryGet(ref _cake3_namehere, "Cake3", "NameHere")
            | Config.TryGet(ref _cake3_foodvalue, "Cake3", "foodvalue")
            | Config.TryGet(ref _cake3_watervalue, "Cake3", "watervalue")
            | Config.TryGet(ref _cake4_namehere, "Cake4", "NameHere")
            | Config.TryGet(ref _cake4_foodvalue, "Cake4", "foodvalue")
            | Config.TryGet(ref _cake4_watervalue, "Cake4", "watervalue")
            ;
            if (_juicenabled == true) { }
            else if (_juicenabled == false) { }
            else
            {
                _juicenabled = true;
                Config["JuicesEnabled"] = _juicenabled;
                Utilites.Logger.Logger.Error("EnabledJuices must be \"true\" or \"false\"", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cakeenabled == true) { }
            else if (_cakeenabled == false) { }
            else
            {
                _cakeenabled = true;
                Config["CakesEnabled"] = _cakeenabled;
                Utilites.Logger.Logger.Error("CakesEnabled must be \"true\" or \"false\"", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice1_namehere == "")
            {
                _juice1_namehere = "namehere1";
                Config["Juice1", "NameHere"] = _juice1_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice1_foodvalue < 0)
            {
                _juice1_foodvalue = 1;
                Config["Juice1", "foodvalue"] = _juice1_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice1_watervalue < 0)
            {
                _juice1_watervalue = 1;
                Config["Juice1", "watervalue"] = _juice1_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice2_namehere == "")
            {
                _juice2_namehere = "namehere2";
                Config["Juice2", "NameHere"] = _juice2_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice2_foodvalue < 0)
            {
                _juice2_foodvalue = 1;
                Config["Juice2", "foodvalue"] = _juice2_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice2_watervalue < 0)
            {
                _juice2_watervalue = 1;
                Config["Juice2", "watervalue"] = _juice2_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice3_namehere == "")
            {
                _juice3_namehere = "namehere3";
                Config["Juice3", "NameHere"] = _juice3_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice3_foodvalue < 0)
            {
                _juice3_foodvalue = 1;
                Config["Juice3", "foodvalue"] = _juice3_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice3_watervalue < 0)
            {
                _juice3_watervalue = 1;
                Config["Juice3", "watervalue"] = _juice3_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice4_namehere == "")
            {
                _juice4_namehere = "namehere3";
                Config["Juice4", "NameHere"] = _juice4_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice4_foodvalue < 0)
            {
                _juice4_foodvalue = 1;
                Config["Juice4", "foodvalue"] = _juice4_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice4_watervalue < 0)
            {
                _juice4_watervalue = 1;
                Config["Juice4", "watervalue"] = _juice4_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice5_namehere == "")
            {
                _juice5_namehere = "namehere3";
                Config["Juice5", "NameHere"] = _juice5_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice5_foodvalue < 0)
            {
                _juice5_foodvalue = 1;
                Config["Juice5", "foodvalue"] = _juice5_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice5_watervalue < 0)
            {
                _juice5_watervalue = 1;
                Config["Juice5", "watervalue"] = _juice5_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice6_namehere == "")
            {
                _juice6_namehere = "namehere3";
                Config["Juice6", "NameHere"] = _juice6_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice6_foodvalue < 0)
            {
                _juice6_foodvalue = 1;
                Config["Juice6", "foodvalue"] = _juice6_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_juice6_watervalue < 0)
            {
                _juice6_watervalue = 1;
                Config["Juice6", "watervalue"] = _juice6_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake1_namehere == "")
            {
                _cake1_namehere = "namehere1";
                Config["Cake1", "NameHere"] = _cake1_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake1_foodvalue < 0)
            {
                _cake1_foodvalue = 1;
                Config["Cake1", "foodvalue"] = _cake1_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake1_watervalue < 0)
            {
                _cake1_watervalue = 1;
                Config["Cake1", "watervalue"] = _cake1_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake2_namehere == "")
            {
                _cake2_namehere = "namehere2";
                Config["Cake2", "NameHere"] = _cake2_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake2_foodvalue < 0)
            {
                _cake2_foodvalue = 1;
                Config["Cake2", "foodvalue"] = _cake2_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake2_watervalue < 0)
            {
                _cake2_watervalue = 1;
                Config["Cake2", "watervalue"] = _cake2_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake3_namehere == "")
            {
                _cake3_namehere = "namehere3";
                Config["Cake3", "NameHere"] = _cake3_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake3_foodvalue < 0)
            {
                _cake3_foodvalue = 1;
                Config["Cake3", "foodvalue"] = _cake3_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake3_watervalue < 0)
            {
                _cake3_watervalue = 1;
                Config["Cake3", "watervalue"] = _cake3_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake4_namehere == "")
            {
                _cake4_namehere = "namehere4";
                Config["Cake4", "NameHere"] = _cake4_namehere;
                Utilites.Logger.Logger.Error("namehere was set to namehere2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake4_foodvalue < 0)
            {
                _cake4_foodvalue = 1;
                Config["Cake4", "foodvalue"] = _cake4_foodvalue;
                Utilites.Logger.Logger.Error("Foodvalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_cake4_watervalue < 0)
            {
                _cake4_watervalue = 1;
                Config["Cake4", "watervalue"] = _cake4_watervalue;
                Utilites.Logger.Logger.Error("Watervalue was set to 1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (configChanged)
            {
                Config.Save();
            }

            //
            //the rest
            //

            AssetBundle = AssetBundle.LoadFromFile(Path.Combine("./QMods/CustomFood/", "customfood.assets"));
            if (AssetBundle == null)
            {
                return;
            }

            var JuiceSprite = AssetBundle.LoadAsset<Sprite>("Filtered_Water");
            var CakesSprite = AssetBundle.LoadAsset<Sprite>("Nutrient_Block");

            CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Juice", "Juice", CraftScheme.Fabricator, JuiceSprite));
            CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Cakes", "Cakes", CraftScheme.Fabricator, CakesSprite));
            if (_juicenabled == true)
            {
                //Juice1
                Logger.Log("Started Patching Juice1");
                CustomJuice1TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_1_ITEM_ID, _juice1_namehere, "Bladderfish mixed with a Peeper.");
                var CustomJuice1Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.Bladderfish, 1),
                    new IngredientHelper(TechType.Peeper, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomJuice1TechType
                };
                CraftDataPatcher.customTechData.Add(CustomJuice1TechType, CustomJuice1Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice1TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice1TechType, CraftScheme.Fabricator, "Survival/Juice/Juice1"));
                KnownTechPatcher.unlockedAtStart.Add(CustomJuice1TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_JUICE_1_ITEM_ID,
                    CUSTOM_JUICE_1_PREFABPATH,
                    CustomJuice1TechType,
                    GetJuice1Bottlle));

                //Juice2
                Logger.Log("Started Patching Juice2");
                CustomJuice2TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_2_ITEM_ID, _juice2_namehere, "Bladderfish mixed with a Boomerang.");
                var CustomJuice2Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.Bladderfish, 1),
                    new IngredientHelper(TechType.Boomerang, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomJuice2TechType
                };
                CraftDataPatcher.customTechData.Add(CustomJuice2TechType, CustomJuice2Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice2TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice2TechType, CraftScheme.Fabricator, "Survival/Juice/Juice2"));
                KnownTechPatcher.unlockedAtStart.Add(CustomJuice2TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_JUICE_2_ITEM_ID,
                    CUSTOM_JUICE_2_PREFABPATH,
                    CustomJuice2TechType,
                    GetJuice2Bottlle));

                //Juice3
                Logger.Log("Started Patching Juice3");
                CustomJuice3TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_3_ITEM_ID, _juice3_namehere, "Bladderfish mixed with a Garryfish.");
                var CustomJuice3Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.Bladderfish, 1),
                    new IngredientHelper(TechType.GarryFish, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomJuice3TechType
                };
                CraftDataPatcher.customTechData.Add(CustomJuice3TechType, CustomJuice3Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice3TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice3TechType, CraftScheme.Fabricator, "Survival/Juice/Juice3"));
                KnownTechPatcher.unlockedAtStart.Add(CustomJuice3TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_JUICE_3_ITEM_ID,
                    CUSTOM_JUICE_3_PREFABPATH,
                    CustomJuice3TechType,
                    GetJuice3Bottlle));

                //Juice4
                Logger.Log("Started Patching Juice4");
                CustomJuice4TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_4_ITEM_ID, _juice4_namehere, "Bladderfish mixed with a Holefish.");
                var CustomJuice4Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.Bladderfish, 1),
                    new IngredientHelper(TechType.HoleFish, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomJuice4TechType
                };
                CraftDataPatcher.customTechData.Add(CustomJuice4TechType, CustomJuice4Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice4TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice4TechType, CraftScheme.Fabricator, "Survival/Juice/Juice4"));
                KnownTechPatcher.unlockedAtStart.Add(CustomJuice4TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_JUICE_4_ITEM_ID,
                    CUSTOM_JUICE_4_PREFABPATH,
                    CustomJuice4TechType,
                    GetJuice4Bottlle));

                //Juice5
                Logger.Log("Started Patching Juice5");
                CustomJuice5TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_5_ITEM_ID, _juice5_namehere, "Bladderfish mixed with a Spadefish.");
                var CustomJuice5Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.Bladderfish, 1),
                    new IngredientHelper(TechType.Spadefish, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomJuice5TechType
                };
                CraftDataPatcher.customTechData.Add(CustomJuice5TechType, CustomJuice5Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice5TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice5TechType, CraftScheme.Fabricator, "Survival/Juice/Juice5"));
                KnownTechPatcher.unlockedAtStart.Add(CustomJuice5TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_JUICE_2_ITEM_ID,
                    CUSTOM_JUICE_2_PREFABPATH,
                    CustomJuice5TechType,
                    GetJuice2Bottlle));

                //Juice6
                Logger.Log("Started Patching Juice6");
                CustomJuice6TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_6_ITEM_ID, _juice6_namehere, "Bladderfish mixed with a Hoverfish.");
                var CustomJuice6Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.Bladderfish, 1),
                    new IngredientHelper(TechType.Hoverfish, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomJuice6TechType
                };
                CraftDataPatcher.customTechData.Add(CustomJuice6TechType, CustomJuice6Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice6TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice6TechType, CraftScheme.Fabricator, "Survival/Juice/Juice6"));
                KnownTechPatcher.unlockedAtStart.Add(CustomJuice6TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_JUICE_6_ITEM_ID,
                    CUSTOM_JUICE_6_PREFABPATH,
                    CustomJuice6TechType,
                    GetJuice6Bottlle));

                var CustomJuice1Sprite = AssetBundle.LoadAsset<Sprite>("Filtered_Water");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice1TechType, CustomJuice1Sprite));
                var CustomJuice2Sprite = AssetBundle.LoadAsset<Sprite>("Filtered_Water");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice2TechType, CustomJuice2Sprite));
                var CustomJuice3Sprite = AssetBundle.LoadAsset<Sprite>("Filtered_Water");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice3TechType, CustomJuice3Sprite));
                var CustomJuice4Sprite = AssetBundle.LoadAsset<Sprite>("Filtered_Water");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice4TechType, CustomJuice4Sprite));
                var CustomJuice5Sprite = AssetBundle.LoadAsset<Sprite>("Filtered_Water");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice5TechType, CustomJuice5Sprite));
                var CustomJuice6Sprite = AssetBundle.LoadAsset<Sprite>("Filtered_Water");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice6TechType, CustomJuice6Sprite));
            }
            if (_cakeenabled == true)
            {
                //CustomCake1
                Logger.Log("Started Patching CustomCake1");
                CustomCake1TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_1_ITEM_ID, _cake1_namehere, "Coral Tube Sample mixed with a Creepvine sample.");
                var CustomCake1Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.CoralChunk, 1),
                    new IngredientHelper(TechType.CreepvinePiece, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomCake1TechType
                };
                CraftDataPatcher.customTechData.Add(CustomCake1TechType, CustomCake1Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake1TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake1TechType, CraftScheme.Fabricator, "Survival/Cakes/CustomCake1"));
                KnownTechPatcher.unlockedAtStart.Add(CustomCake1TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_CAKE_1_ITEM_ID,
                    CUSTOM_CAKE_1_PREFABPATH,
                    CustomCake1TechType,
                    GetCustomCake1Bottle));

                //CustomCake2
                Logger.Log("Started Patching CustomCake2");
                CustomCake2TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_2_ITEM_ID, _cake2_namehere, "Coral Tube Sample mixed with a Lantern fruit sample.");
                var CustomCake2Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.CoralChunk, 1),
                    new IngredientHelper(TechType.HangingFruit, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomCake2TechType
                };
                CraftDataPatcher.customTechData.Add(CustomCake2TechType, CustomCake2Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake2TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake2TechType, CraftScheme.Fabricator, "Survival/Cakes/CustomCake2"));
                KnownTechPatcher.unlockedAtStart.Add(CustomCake2TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_CAKE_2_ITEM_ID,
                    CUSTOM_CAKE_2_PREFABPATH,
                    CustomCake2TechType,
                    GetCustomCake2Bottle));

                //CustomCake3
                Logger.Log("Started Patching CustomCake3");
                CustomCake3TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_3_ITEM_ID, _cake3_namehere, "Coral Tube Sample mixed with a Chinese Potato.");
                var CustomCake3Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.CoralChunk, 1),
                    new IngredientHelper(TechType.PurpleVegetable, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomCake3TechType
                };
                CraftDataPatcher.customTechData.Add(CustomCake3TechType, CustomCake3Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake3TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake3TechType, CraftScheme.Fabricator, "Survival/Cakes/CustomCake3"));
                KnownTechPatcher.unlockedAtStart.Add(CustomCake3TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_CAKE_3_ITEM_ID,
                    CUSTOM_CAKE_3_PREFABPATH,
                    CustomCake3TechType,
                    GetCustomCake3Bottle));

                //CustomCake4
                Logger.Log("Started Patching CustomCake4");
                CustomCake4TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_4_ITEM_ID, _cake4_namehere, "Coral Tube Sample mixed with a Bulbo Tree Sample.");
                var CustomCake4Data = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(TechType.CoralChunk, 1),
                    new IngredientHelper(TechType.BulboTreePiece, 1)
                },
                    _linkedItems = new List<TechType>()
                    {
                    },
                    _techType = CustomCake4TechType
                };
                CraftDataPatcher.customTechData.Add(CustomCake4TechType, CustomCake4Data);
                CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake4TechType);
                CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake4TechType, CraftScheme.Fabricator, "Survival/Cakes/CustomCake4"));
                KnownTechPatcher.unlockedAtStart.Add(CustomCake4TechType);

                CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                    CUSTOM_CAKE_4_ITEM_ID,
                    CUSTOM_CAKE_4_PREFABPATH,
                    CustomCake4TechType,
                    GetCustomCake4Bottle));

                var CustomCake1Sprite = AssetBundle.LoadAsset<Sprite>("Nutrient_Block");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake1TechType, CustomCake1Sprite));
                var CustomCake2Sprite = AssetBundle.LoadAsset<Sprite>("Nutrient_Block");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake2TechType, CustomCake2Sprite));
                var CustomCake3Sprite = AssetBundle.LoadAsset<Sprite>("Nutrient_Block");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake3TechType, CustomCake3Sprite));
                var CustomCake4Sprite = AssetBundle.LoadAsset<Sprite>("Nutrient_Block");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake4TechType, CustomCake4Sprite));
            }
        }
        public static GameObject GetJuice1Bottlle()
        {

            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_JUICE_1_ITEM_ID;
            techTag.type = CustomJuice1TechType;
            eatable.foodValue = _juice1_foodvalue;
            eatable.waterValue = _juice1_watervalue;

            return obj;
        }
        public static GameObject GetJuice2Bottlle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_JUICE_2_ITEM_ID;
            techTag.type = CustomJuice2TechType;
            eatable.foodValue = _juice2_foodvalue;
            eatable.waterValue = _juice2_watervalue;
            return obj;
        }
        public static GameObject GetJuice3Bottlle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_JUICE_3_ITEM_ID;
            techTag.type = CustomJuice3TechType;
            eatable.foodValue = _juice3_foodvalue;
            eatable.waterValue = _juice3_watervalue;
            return obj;
        }
        public static GameObject GetJuice4Bottlle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_JUICE_4_ITEM_ID;
            techTag.type = CustomJuice4TechType;
            eatable.foodValue = _juice4_foodvalue;
            eatable.waterValue = _juice4_watervalue;
            return obj;
        }
        public static GameObject GetJuice5Bottlle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_JUICE_5_ITEM_ID;
            techTag.type = CustomJuice5TechType;
            eatable.foodValue = _juice5_foodvalue;
            eatable.waterValue = _juice5_watervalue;
            return obj;
        }
        public static GameObject GetJuice6Bottlle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_JUICE_6_ITEM_ID;
            techTag.type = CustomJuice6TechType;
            eatable.foodValue = _juice6_foodvalue;
            eatable.waterValue = _juice6_watervalue;
            return obj;
        }
        public static GameObject GetCustomCake1Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_CAKE_1_ITEM_ID;
            techTag.type = CustomCake1TechType;
            eatable.foodValue = _cake1_foodvalue;
            eatable.waterValue = _cake1_watervalue;

            return obj;
        }
        public static GameObject GetCustomCake2Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_CAKE_2_ITEM_ID;
            techTag.type = CustomCake2TechType;
            eatable.foodValue = _cake2_foodvalue;
            eatable.waterValue = _cake2_watervalue;

            return obj;
        }
        public static GameObject GetCustomCake3Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_CAKE_3_ITEM_ID;
            techTag.type = CustomCake3TechType;
            eatable.foodValue = _cake3_foodvalue;
            eatable.waterValue = _cake3_watervalue;

            return obj;
        }
        public static GameObject GetCustomCake4Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_CAKE_4_ITEM_ID;
            techTag.type = CustomCake4TechType;
            eatable.foodValue = _cake4_foodvalue;
            eatable.waterValue = _cake4_watervalue;

            return obj;
        }
    }
}