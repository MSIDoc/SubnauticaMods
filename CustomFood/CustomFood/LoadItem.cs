using System;
using System.Collections.Generic;
using SMLHelper;
using SMLHelper.Patchers;
using Utilites;
using Utilites.Config;

namespace CustomFood
{
    /// <summary>
    /// Main class for loading items
    /// </summary>
    public class LoadItem
    {
        private const string configColorPath = Cfg.configColorPath;
        public static ConfigFile Config = Cfg.Config;

        public static TechType _juice1tt;
        public static TechType _juice2tt;
        public static TechType _juice3tt;
        public static TechType _juice4tt;
        public static TechType _juice5tt;
        public static TechType _juice6tt;
        public static TechType _juice7tt;
        public static TechType _juice8tt;
        public static TechType _cake1tt;
        public static TechType _cake2tt;
        public static TechType _cake3tt;
        public static TechType _cake4tt;
        public static TechType _cake5tt;
        public static TechType _cake6tt;
        public static TechType _cake7tt;
        public static TechType _cake8tt;

        public static TechType techType;

        public static string _sprite;

        private static string type;
        private static string name;

        public static List<IngredientHelper> ingredients = new List<IngredientHelper>();

        public static TechDataHelper techData;

        /// <summary>
        /// Loads an item
        /// </summary>
        /// <param name="typ">Must be "Juice" or "Cake"</param>
        /// <param name="numbr">Must be between 1 and 8</param>
        public static void Load(string typ, int numbr)
        {
            try
            {
                var _enabled = true;
                var _name = "Name";
                var _tooltip = "Tooltip";
                var _foodvalue = 1;
                var _watervalue = 1;
                var _ingredient1 = "None";
                var _ingredient1amount = 1;
                var _ingredient2 = "None";
                var _ingredient2amount = 1;
                var _ingredient3 = "None";
                var _ingredient3amount = 1;
                var _ingredient4 = "None";
                var _ingredient4amount = 1;
                var _ingredient5 = "None";
                var _ingredient5amount = 1;
                var _x = 1;
                var _y = 1;
                var number = numbr.ToString();
                type = typ + "s";
                name = typ + number;
                var internal_name = "Custom" + name;
                var _sprite = "Default";
                var prefabpath = "WorldEntities/Food/" + internal_name;
                Config.TryGet(ref _enabled, type, name, "Enabled");
                Config.TryGet(ref _name, type, name, "Name");
                Config.TryGet(ref _tooltip, type, name, "Tooltip");
                Config.TryGet(ref _foodvalue, type, name, "Values", "Food");
                Config.TryGet(ref _watervalue, type, name, "Values", "Water");
                Config.TryGet(ref _ingredient1, type, name, "Ingredients", "Ingredient1", "Item");
                Config.TryGet(ref _ingredient1amount, type, name, "Ingredients", "Ingredient1", "Amount");
                Config.TryGet(ref _ingredient2, type, name, "Ingredients", "Ingredient2", "Item");
                Config.TryGet(ref _ingredient2amount, type, name, "Ingredients", "Ingredient2", "Amount");
                Config.TryGet(ref _ingredient3, type, name, "Ingredients", "Ingredient3", "Item");
                Config.TryGet(ref _ingredient3amount, type, name, "Ingredients", "Ingredient3", "Amount");
                Config.TryGet(ref _ingredient4, type, name, "Ingredients", "Ingredient4", "Item");
                Config.TryGet(ref _ingredient4amount, type, name, "Ingredients", "Ingredient4", "Amount");
                Config.TryGet(ref _ingredient5, type, name, "Ingredients", "Ingredient5", "Item");
                Config.TryGet(ref _ingredient5amount, type, name, "Ingredients", "Ingredient5", "Amount");
                Config.TryGet(ref _x, type, name, "Size", "X");
                Config.TryGet(ref _y, type, name, "Size", "Y");
                Config.TryGet(ref _sprite, type, name, configColorPath);
                Log.Debug("Started loading " + name);
                if (_enabled == false)
                {
                    return;
                }
                if (_name == "")
                {
                    _name = "Name can't be blank";
                    Config[type, name, "Name"] = _name;
                    Log.Warning(name, "Name can't be blank");
                    Log.Info(name, "Name was set to 'Name can't be blank'");
                }
                if (_x < 1)
                {
                    _x = 1;
                    Config[type, name, "Size", "X"] = _x;
                    Log.Warning(name, "X Size can't be less than 1");
                    Log.Info(name, "X was set to 1");
                }
                if (_x > 6)
                {
                    _x = 1;
                    Config[type, name, "Size", "X"] = _x;
                    Log.Warning(name, "X Size can't be greater than 6");
                    Log.Info(name, "X was set to 1");
                }
                if (_y < 1)
                {
                    _y = 1;
                    Config[type, name, "Size", "Y"] = _y;
                    Log.Warning(name, "Y Size can't be less than 1");
                    Log.Info(name, "Y was set to 1");
                }
                if (_y > 8)
                {
                    _y = 1;
                    Config[type, name, "Size", "Y"] = _y;
                    Log.Warning(name, "Y Size can't be greater than 8");
                    Log.Info(name, "Y was set to 1");
                }
                CheckIngredients(_ingredient1, _ingredient1amount, 1);
                CheckIngredients(_ingredient2, _ingredient2amount, 2);
                CheckIngredients(_ingredient3, _ingredient3amount, 3);
                CheckIngredients(_ingredient4, _ingredient4amount, 4);
                CheckIngredients(_ingredient5, _ingredient5amount, 5);
                Cfg.Save();
                techType = TechTypePatcher.AddTechType(internal_name, _name, _tooltip + Cfg._tooltipsuffix);
                if (name == "Juice1")
                {
                    _juice1tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice1));
                }
                if (name == "Juice2")
                {
                    _juice2tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice2));
                }
                if (name == "Juice3")
                {
                    _juice3tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice3));
                }
                if (name == "Juice4")
                {
                    _juice4tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice4));
                }
                if (name == "Juice5")
                {
                    _juice5tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice5));
                }
                if (name == "Juice6")
                {
                    _juice6tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice6));
                }
                if (name == "Juice7")
                {
                    _juice7tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice7));
                }
                if (name == "Juice8")
                {
                    _juice8tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice8));
                }
                if (name == "Cake1")
                {
                    _cake1tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake1));
                }
                if (name == "Cake2")
                {
                    _cake2tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake2));
                }
                if (name == "Cake3")
                {
                    _cake3tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake3));
                }
                if (name == "Cake4")
                {
                    _cake4tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake4));
                }
                if (name == "Cake5")
                {
                    _cake5tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake5));
                }
                if (name == "Cake6")
                {
                    _cake6tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake6));
                }
                if (name == "Cake7")
                {
                    _cake7tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake7));
                }
                if (name == "Cake8")
                {
                    _cake8tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake8));
                }
                ApplyTechData();
                KnownTechPatcher.unlockedAtStart.Add(techType);
                if (type == "Cakes")
                {
                    ApplySprite.Cake(techType, _sprite);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(techType, CraftScheme.Fabricator, "Survival/Cakes/" + internal_name));
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CuredFood, techType);
                }
                if (type == "Juices")
                {
                    ApplySprite.Juice(techType, _sprite);
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(techType, CraftScheme.Fabricator, "Survival/Juices/" + internal_name));
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, techType);
                }
                CraftDataPatcher.customItemSizes[key: techType] = new Vector2int(_x, _y);
                ingredients.Clear();
                Log.Debug("Finished loading " + name);
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
        public static void DummySpriteTechTypes()
        {
            if (Cfg._debug)
            {
                var juicedefault = TechTypePatcher.AddTechType("SpriteJuiceDefault", "Default Juice", "The sprite should be default (just like filtered water)");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juicedefault, Cfg.juice_default));

                var juiceblue = TechTypePatcher.AddTechType("SpriteJuiceBlue", "Blue Juice", "The sprite should be blue");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juiceblue, Cfg.juice_blue));

                var juicebluegreen = TechTypePatcher.AddTechType("SpriteJuiceBlueGreen", "BlueGreen Juice", "The sprite should be blue-green");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juicebluegreen, Cfg.juice_bluegreen));

                var juicegreen = TechTypePatcher.AddTechType("SpriteJuiceGreen", "Green Juice", "The sprite should be green");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juicegreen, Cfg.juice_green));

                var juicelightblue = TechTypePatcher.AddTechType("SpriteJuiceLightBlue", "LightBlue Juice", "The sprite should be light blue");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juicelightblue, Cfg.juice_lightblue));

                var juiceorange = TechTypePatcher.AddTechType("SpriteJuiceOrange", "Orange Juice", "The sprite should be orange");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juiceorange, Cfg.juice_orange));

                var juicepink = TechTypePatcher.AddTechType("SpriteJuicePink", "Pink Juice", "The sprite should be pink");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juicepink, Cfg.juice_pink));

                var juicepurple = TechTypePatcher.AddTechType("SpriteJuicePurple", "Purple Juice", "The sprite should be purple");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juicepurple, Cfg.juice_purple));

                var juicered = TechTypePatcher.AddTechType("SpriteJuiceRed", "Red Juice", "The sprite should be red");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juicered, Cfg.juice_red));

                var juiceyellow = TechTypePatcher.AddTechType("SpriteJuiceYellow", "Yellow Juice", "The sprite should be yellow");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(juiceyellow, Cfg.juice_yellow));

                var cakedefault = TechTypePatcher.AddTechType("SpriteCakeDefault", "Default Cake", "The sprite should be default (just like nutrient block)");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakedefault, Cfg.cake_default));

                var cakeblue = TechTypePatcher.AddTechType("SpriteCakeBlue", "Blue Cake", "The sprite should be blue");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakeblue, Cfg.cake_blue));

                var cakebluegreen = TechTypePatcher.AddTechType("SpriteCakeBlueGreen", "BlueGreen Cake", "The sprite should be blue-green");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakebluegreen, Cfg.cake_bluegreen));

                var cakegreen = TechTypePatcher.AddTechType("SpriteCakeGreen", "Green Cake", "The sprite should be green");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakegreen, Cfg.cake_green));

                var cakelightblue = TechTypePatcher.AddTechType("SpriteCakeLightBlue", "LightBlue Cake", "The sprite should be light blue");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakelightblue, Cfg.cake_lightblue));

                var cakeorange = TechTypePatcher.AddTechType("SpriteCakeOrange", "Orange Cake", "The sprite should be orange");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakeorange, Cfg.cake_orange));

                var cakepink = TechTypePatcher.AddTechType("SpriteCakePink", "Pink Cake", "The sprite should be pink");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakepink, Cfg.cake_pink));

                var cakepurple = TechTypePatcher.AddTechType("SpriteCakePurple", "Purple Cake", "The sprite should be purple");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakepurple, Cfg.cake_purple));

                var cakered = TechTypePatcher.AddTechType("SpriteCakeRed", "Red Cake", "The sprite should be red");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakered, Cfg.cake_red));

                var cakeyellow = TechTypePatcher.AddTechType("SpriteCakeYellow", "Yellow Cake", "The sprite should be yellow");
                CustomSpriteHandler.customSprites.Add(new CustomSprite(cakeyellow, Cfg.cake_yellow));
            }
        }
        public static void CheckIngredients(string item, int amount, int ingNo)
        {
            if ((amount != 0) && (item != "None"))
            {
                if (amount < 0)
                {
                    amount = 1;
                    Config[type, name, "Ingredients", $"Ingredient{ingNo}", "Amount"] = amount;
                    Log.Warning(name, $"Ingredient{ingNo} amount must not be less than 1");
                    Log.Info(name, $"Ingredient{ingNo} amount was set to 1");
                }
                if (!Enum.IsDefined(typeof(TechType), item))
                {
                    item = $"Ingredient {ingNo} invalid (Old value: {item})";
                    Config[type, name, "Ingredients", $"Ingredient{ingNo}", "Item"] = item;
                    Log.Warning(name, $"Ingredient{ingNo} must be a TechType");
                    Log.Info(name, $"Ingredient{ingNo} was set to a dummy value and disabled");
                    amount = 0;
                }
                else
                {
                    ingredients.Add(new IngredientHelper((TechType)Enum.Parse(typeof(TechType), item), amount));
                }
            }
            else
            {
                Log.Debug(name, $"Ingredient {ingNo} is disabled. Ignoring...");
            }
        }
        public static void ApplyTechData()
        {
            if (ingredients.Count == 0)
            {
                Log.Warning(name, "The item has no valid ingredients and will not be able to be crafted!");
            }
            if (ingredients.Count == 1)
            {
                techData = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    ingredients.GetLast()
                },
                    _techType = techType
                };
            }
            if (ingredients.Count == 2)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);

                techData = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                    {
                        i1,
                        ingredients.GetLast()
                    },
                    _techType = techType
                };
            }
            if (ingredients.Count == 3)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);
                var i2 = ingredients.GetLast();
                ingredients.Remove(i2);

                techData = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                    {
                        i1,
                        i2,
                        ingredients.GetLast()
                    },
                    _techType = techType
                };
            }
            if (ingredients.Count == 4)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);
                var i2 = ingredients.GetLast();
                ingredients.Remove(i2);
                var i3 = ingredients.GetLast();
                ingredients.Remove(i3);

                techData = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                    {
                        i1,
                        i2,
                        i3,
                        ingredients.GetLast()
                    },
                    _techType = techType
                };
            }
            if (ingredients.Count == 5)
            {
                var i1 = ingredients.GetLast();
                ingredients.Remove(i1);
                var i2 = ingredients.GetLast();
                ingredients.Remove(i2);
                var i3 = ingredients.GetLast();
                ingredients.Remove(i3);
                var i4 = ingredients.GetLast();
                ingredients.Remove(i4);

                techData = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                    {
                        i1,
                        i2,
                        i3,
                        i4,
                        ingredients.GetLast()
                    },
                    _techType = techType
                };
            }
            CraftDataPatcher.customTechData.Add(techType, techData);
        }
    }
}
