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

namespace CustomFood
{
    public class QPatch
    {
        public static AssetBundle AssetBundle;
        public const string CUSTOM_JUICE_1_ITEM_ID = "CustomJuice1";
        public static string CUSTOM_JUICE_1_PREFABPATH = "WorldEntities/Food/juice1";
        public static TechType CustomJuice1TechType;
        public static TechType CustomJuice1Ingredient1;
        public static TechType CustomJuice1Ingredient2;

        public const string CUSTOM_JUICE_2_ITEM_ID = "CustomJuice2";
        public static string CUSTOM_JUICE_2_PREFABPATH = "WorldEntities/Food/juice2";
        public static TechType CustomJuice2TechType;
        public static TechType CustomJuice2Ingredient1;
        public static TechType CustomJuice2Ingredient2;

        public const string CUSTOM_JUICE_3_ITEM_ID = "CustomJuice3";
        public static string CUSTOM_JUICE_3_PREFABPATH = "WorldEntities/Food/juice3";
        public static TechType CustomJuice3TechType;
        public static TechType CustomJuice3Ingredient1;
        public static TechType CustomJuice3Ingredient2;

        public const string CUSTOM_JUICE_4_ITEM_ID = "CustomJuice4";
        public static string CUSTOM_JUICE_4_PREFABPATH = "WorldEntities/Food/juice4";
        public static TechType CustomJuice4TechType;
        public static TechType CustomJuice4Ingredient1;
        public static TechType CustomJuice4Ingredient2;

        public const string CUSTOM_JUICE_5_ITEM_ID = "CustomJuice5";
        public static string CUSTOM_JUICE_5_PREFABPATH = "WorldEntities/Food/juice5";
        public static TechType CustomJuice5TechType;
        public static TechType CustomJuice5Ingredient1;
        public static TechType CustomJuice5Ingredient2;

        public const string CUSTOM_JUICE_6_ITEM_ID = "CustomJuice6";
        public static string CUSTOM_JUICE_6_PREFABPATH = "WorldEntities/Food/juice6";
        public static TechType CustomJuice6TechType;
        public static TechType CustomJuice6Ingredient1;
        public static TechType CustomJuice6Ingredient2;

        public const string CUSTOM_CAKE_1_ITEM_ID = "CustomCake1";
        public static string CUSTOM_CAKE_1_PREFABPATH = "WorldEntities/Food/CustomCake1";
        public static TechType CustomCake1TechType;
        public static TechType CustomCake1Ingredient1;
        public static TechType CustomCake1Ingredient2;

        public const string CUSTOM_CAKE_2_ITEM_ID = "CustomCake2";
        public static string CUSTOM_CAKE_2_PREFABPATH = "WorldEntities/Food/CustomCake2";
        public static TechType CustomCake2TechType;
        public static TechType CustomCake2Ingredient1;
        public static TechType CustomCake2Ingredient2;

        public const string CUSTOM_CAKE_3_ITEM_ID = "CustomCake3";
        public static string CUSTOM_CAKE_3_PREFABPATH = "WorldEntities/Food/CustomCake3";
        public static TechType CustomCake3TechType;
        public static TechType CustomCake3Ingredient1;
        public static TechType CustomCake3Ingredient2;

        public const string CUSTOM_CAKE_4_ITEM_ID = "CustomCake4";
        public static string CUSTOM_CAKE_4_PREFABPATH = "WorldEntities/Food/CustomCake4";
        public static TechType CustomCake4TechType;
        public static TechType CustomCake4Ingredient1;
        public static TechType CustomCake4Ingredient2;

        public const string CUSTOM_CAKE_5_ITEM_ID = "CustomCake5";
        public static string CUSTOM_CAKE_5_PREFABPATH = "WorldEntities/Food/CustomCake5";
        public static TechType CustomCake5TechType;
        public static TechType CustomCake5Ingredient1;
        public static TechType CustomCake5Ingredient2;

        public const string CUSTOM_CAKE_6_ITEM_ID = "CustomCake6";
        public static string CUSTOM_CAKE_6_PREFABPATH = "WorldEntities/Food/CustomCake6";
        public static TechType CustomCake6TechType;
        public static TechType CustomCake6Ingredient1;
        public static TechType CustomCake6Ingredient2;

        public static void Patch()
        {
            try
            {
                Log.Info("Started loading");
                Cfg.Init();

                CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Juices", "Juices", CraftScheme.Fabricator, Cfg.JuiceSprite));
                CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Cakes", "Cakes", CraftScheme.Fabricator, Cfg.CakesSprite));

                CustomJuice1Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice1_ingredient1);
                CustomJuice1Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice1_ingredient2);
                CustomJuice2Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice2_ingredient1);
                CustomJuice2Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice2_ingredient2);
                CustomJuice3Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice3_ingredient1);
                CustomJuice3Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice3_ingredient2);
                CustomJuice4Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice4_ingredient1);
                CustomJuice4Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice4_ingredient2);
                CustomJuice5Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice5_ingredient1);
                CustomJuice5Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice5_ingredient2);
                CustomJuice6Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice6_ingredient1);
                CustomJuice6Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._juice6_ingredient2);

                CustomCake1Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake1_ingredient1);
                CustomCake1Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake1_ingredient2);
                CustomCake2Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake2_ingredient1);
                CustomCake2Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake2_ingredient2);
                CustomCake3Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake3_ingredient1);
                CustomCake3Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake3_ingredient2);
                CustomCake4Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake4_ingredient1);
                CustomCake4Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake4_ingredient2);
                CustomCake5Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake5_ingredient1);
                CustomCake5Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake5_ingredient2);
                CustomCake6Ingredient1 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake6_ingredient1);
                CustomCake6Ingredient2 = (TechType)Enum.Parse(typeof(TechType), Cfg._cake6_ingredient2);

                if (Cfg._juicenabled == true)
                {
                    //Juice1
                    CustomJuice1TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_1_ITEM_ID, Cfg._juice1_namehere, Cfg._juice1_tooltip + Cfg._tooltipsuffix);
                    var CustomJuice1Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomJuice1Ingredient1, Cfg._juice1_ingredient1amount),
                    new IngredientHelper(CustomJuice1Ingredient2, Cfg._juice1_ingredient2amount),
                },
                        _techType = CustomJuice1TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomJuice1TechType, CustomJuice1Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice1TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice1TechType, CraftScheme.Fabricator, "Survival/Juices/" + Cfg._juice1_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice1TechType, Cfg.JuiceSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_JUICE_1_ITEM_ID,
                        CUSTOM_JUICE_1_PREFABPATH,
                        CustomJuice1TechType,
                        GetJuice1Bottlle));

                    //Juice2
                    CustomJuice2TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_2_ITEM_ID, Cfg._juice2_namehere, Cfg._juice2_tooltip + Cfg._tooltipsuffix);
                    var CustomJuice2Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomJuice2Ingredient1, Cfg._juice2_ingredient1amount),
                    new IngredientHelper(CustomJuice2Ingredient2, Cfg._juice2_ingredient2amount),
                },
                        _techType = CustomJuice2TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomJuice2TechType, CustomJuice2Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice2TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice2TechType, CraftScheme.Fabricator, "Survival/Juices/" + Cfg._juice2_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice2TechType, Cfg.JuiceSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_JUICE_2_ITEM_ID,
                        CUSTOM_JUICE_2_PREFABPATH,
                        CustomJuice2TechType,
                        GetJuice2Bottlle));

                    //Juice3
                    CustomJuice3TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_3_ITEM_ID, Cfg._juice3_namehere, Cfg._juice3_tooltip + Cfg._tooltipsuffix);
                    var CustomJuice3Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomJuice3Ingredient1, Cfg._juice3_ingredient1amount),
                    new IngredientHelper(CustomJuice3Ingredient2, Cfg._juice3_ingredient2amount),
                },
                        _techType = CustomJuice3TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomJuice3TechType, CustomJuice3Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice3TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice3TechType, CraftScheme.Fabricator, "Survival/Juices/" + Cfg._juice3_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice3TechType, Cfg.JuiceSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_JUICE_3_ITEM_ID,
                        CUSTOM_JUICE_3_PREFABPATH,
                        CustomJuice3TechType,
                        GetJuice3Bottlle));

                    //Juice4
                    CustomJuice4TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_4_ITEM_ID, Cfg._juice4_namehere, Cfg._juice4_tooltip + Cfg._tooltipsuffix);
                    var CustomJuice4Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomJuice4Ingredient1, Cfg._juice4_ingredient1amount),
                    new IngredientHelper(CustomJuice4Ingredient2, Cfg._juice4_ingredient2amount),
                },
                        _techType = CustomJuice4TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomJuice4TechType, CustomJuice4Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice4TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice4TechType, CraftScheme.Fabricator, "Survival/Juices/" + Cfg._juice4_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice4TechType, Cfg.JuiceSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_JUICE_4_ITEM_ID,
                        CUSTOM_JUICE_4_PREFABPATH,
                        CustomJuice4TechType,
                        GetJuice4Bottlle));

                    //Juice5
                    CustomJuice5TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_5_ITEM_ID, Cfg._juice5_namehere, Cfg._juice5_tooltip + Cfg._tooltipsuffix);
                    var CustomJuice5Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomJuice5Ingredient1, Cfg._juice5_ingredient1amount),
                    new IngredientHelper(CustomJuice5Ingredient2, Cfg._juice5_ingredient2amount),
                },
                        _techType = CustomJuice5TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomJuice5TechType, CustomJuice5Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice5TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice5TechType, CraftScheme.Fabricator, "Survival/Juices/" + Cfg._juice5_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice5TechType, Cfg.JuiceSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_JUICE_2_ITEM_ID,
                        CUSTOM_JUICE_2_PREFABPATH,
                        CustomJuice5TechType,
                        GetJuice2Bottlle));

                    //Juice6
                    CustomJuice6TechType = TechTypePatcher.AddTechType(CUSTOM_JUICE_6_ITEM_ID, Cfg._juice6_namehere, Cfg._juice6_tooltip + Cfg._tooltipsuffix);
                    var CustomJuice6Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomJuice6Ingredient1, Cfg._juice6_ingredient1amount),
                    new IngredientHelper(CustomJuice6Ingredient2, Cfg._juice6_ingredient2amount),
                },
                        _techType = CustomJuice6TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomJuice6TechType, CustomJuice6Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, CustomJuice6TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomJuice6TechType, CraftScheme.Fabricator, "Survival/Juices/" + Cfg._juice6_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomJuice6TechType, Cfg.JuiceSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_JUICE_6_ITEM_ID,
                        CUSTOM_JUICE_6_PREFABPATH,
                        CustomJuice6TechType,
                        GetJuice6Bottlle));

                }
                if (Cfg._cakeenabled == true)
                {
                    //CustomCake1
                    CustomCake1TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_1_ITEM_ID, Cfg._cake1_namehere, Cfg._cake1_tooltip + Cfg._tooltipsuffix);
                    var CustomCake1Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomCake1Ingredient1, Cfg._cake1_ingredient1amount),
                    new IngredientHelper(CustomCake1Ingredient2, Cfg._cake1_ingredient2amount),
                },
                        _techType = CustomCake1TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomCake1TechType, CustomCake1Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake1TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake1TechType, CraftScheme.Fabricator, "Survival/Cakes/" + Cfg._cake1_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake1TechType, Cfg.CakesSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_CAKE_1_ITEM_ID,
                        CUSTOM_CAKE_1_PREFABPATH,
                        CustomCake1TechType,
                        GetCustomCake1Bottle));

                    //CustomCake2
                    CustomCake2TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_2_ITEM_ID, Cfg._cake2_namehere, Cfg._cake2_tooltip + Cfg._tooltipsuffix);
                    var CustomCake2Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomCake2Ingredient1, Cfg._cake2_ingredient1amount),
                    new IngredientHelper(CustomCake2Ingredient2, Cfg._cake2_ingredient2amount),
                },
                        _techType = CustomCake2TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomCake2TechType, CustomCake2Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake2TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake2TechType, CraftScheme.Fabricator, "Survival/Cakes/" + Cfg._cake2_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake2TechType, Cfg.CakesSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_CAKE_2_ITEM_ID,
                        CUSTOM_CAKE_2_PREFABPATH,
                        CustomCake2TechType,
                        GetCustomCake2Bottle));

                    //CustomCake3
                    CustomCake3TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_3_ITEM_ID, Cfg._cake3_namehere, Cfg._cake3_tooltip + Cfg._tooltipsuffix);
                    var CustomCake3Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomCake3Ingredient1, Cfg._cake3_ingredient1amount),
                    new IngredientHelper(CustomCake3Ingredient2, Cfg._cake3_ingredient2amount),
                },
                        _techType = CustomCake3TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomCake3TechType, CustomCake3Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake3TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake3TechType, CraftScheme.Fabricator, "Survival/Cakes/" + Cfg._cake3_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake3TechType, Cfg.CakesSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_CAKE_3_ITEM_ID,
                        CUSTOM_CAKE_3_PREFABPATH,
                        CustomCake3TechType,
                        GetCustomCake3Bottle));

                    //CustomCake4
                    CustomCake4TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_4_ITEM_ID, Cfg._cake4_namehere, Cfg._cake4_tooltip + Cfg._tooltipsuffix);
                    var CustomCake4Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomCake4Ingredient1, Cfg._cake4_ingredient1amount),
                    new IngredientHelper(CustomCake4Ingredient2, Cfg._cake4_ingredient2amount),
                },
                        _techType = CustomCake4TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomCake4TechType, CustomCake4Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake4TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake4TechType, CraftScheme.Fabricator, "Survival/Cakes/" + Cfg._cake4_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake4TechType, Cfg.CakesSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_CAKE_4_ITEM_ID,
                        CUSTOM_CAKE_4_PREFABPATH,
                        CustomCake4TechType,
                        GetCustomCake4Bottle));

                    //CustomCake5
                    CustomCake5TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_5_ITEM_ID, Cfg._cake5_namehere, Cfg._cake5_tooltip + Cfg._tooltipsuffix);
                    var CustomCake5Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomCake5Ingredient1, Cfg._cake5_ingredient1amount),
                    new IngredientHelper(CustomCake5Ingredient2, Cfg._cake5_ingredient2amount),
                },
                        _techType = CustomCake5TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomCake5TechType, CustomCake5Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake5TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake5TechType, CraftScheme.Fabricator, "Survival/Cakes/" + Cfg._cake5_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake5TechType, Cfg.CakesSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_CAKE_5_ITEM_ID,
                        CUSTOM_CAKE_5_PREFABPATH,
                        CustomCake5TechType,
                        GetCustomCake5Bottle));

                    //CustomCake6
                    CustomCake6TechType = TechTypePatcher.AddTechType(CUSTOM_CAKE_6_ITEM_ID, Cfg._cake6_namehere, Cfg._cake6_tooltip + Cfg._tooltipsuffix);
                    var CustomCake6Data = new TechDataHelper
                    {
                        _craftAmount = 1,
                        _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(CustomCake6Ingredient1, Cfg._cake6_ingredient1amount),
                    new IngredientHelper(CustomCake6Ingredient2, Cfg._cake6_ingredient2amount),
                },
                        _techType = CustomCake6TechType
                    };
                    CraftDataPatcher.customTechData.Add(CustomCake6TechType, CustomCake6Data);
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CookedFood, CustomCake6TechType);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(CustomCake6TechType, CraftScheme.Fabricator, "Survival/Cakes/" + Cfg._cake6_namehere));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(CustomCake6TechType, Cfg.CakesSprite));

                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        CUSTOM_CAKE_6_ITEM_ID,
                        CUSTOM_CAKE_6_PREFABPATH,
                        CustomCake6TechType,
                        GetCustomCake6Bottle));
                }
                Log.Info("Finished loading");
            }
            catch (Exception e)
            {
                Log.e(e);
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
            eatable.foodValue = Cfg._juice1_foodvalue;
            eatable.waterValue = Cfg._juice1_watervalue;

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
            eatable.foodValue = Cfg._juice2_foodvalue;
            eatable.waterValue = Cfg._juice2_watervalue;
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
            eatable.foodValue = Cfg._juice3_foodvalue;
            eatable.waterValue = Cfg._juice3_watervalue;
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
            eatable.foodValue = Cfg._juice4_foodvalue;
            eatable.waterValue = Cfg._juice4_watervalue;
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
            eatable.foodValue = Cfg._juice5_foodvalue;
            eatable.waterValue = Cfg._juice5_watervalue;
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
            eatable.foodValue = Cfg._juice6_foodvalue;
            eatable.waterValue = Cfg._juice6_watervalue;
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
            eatable.foodValue = Cfg._cake1_foodvalue;
            eatable.waterValue = Cfg._cake1_watervalue;

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
            eatable.foodValue = Cfg._cake2_foodvalue;
            eatable.waterValue = Cfg._cake2_watervalue;

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
            eatable.foodValue = Cfg._cake3_foodvalue;
            eatable.waterValue = Cfg._cake3_watervalue;

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
            eatable.foodValue = Cfg._cake4_foodvalue;
            eatable.waterValue = Cfg._cake4_watervalue;

            return obj;
        }
        public static GameObject GetCustomCake5Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_CAKE_5_ITEM_ID;
            techTag.type = CustomCake5TechType;
            eatable.foodValue = Cfg._cake5_foodvalue;
            eatable.waterValue = Cfg._cake5_watervalue;

            return obj;
        }
        public static GameObject GetCustomCake6Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = CUSTOM_CAKE_6_ITEM_ID;
            techTag.type = CustomCake6TechType;
            eatable.foodValue = Cfg._cake6_foodvalue;
            eatable.waterValue = Cfg._cake6_watervalue;

            return obj;
        }
    }
}