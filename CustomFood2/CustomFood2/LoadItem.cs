using System;
using System.Collections.Generic;
using SMLHelper;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Assets;
using Utilites;
using Utilites.Config;
using SMLHelper.V2.Utility;
using SMLHelper.Patchers;

namespace CustomFood2
{
    /// <summary>
    /// Main class for loading items
    /// </summary>
    public class LoadItem
    {
        public static ConfigFile Config = Cfg.Config;

        public static TechType _juice1tt;
        public static TechType _juice2tt;
        public static TechType _juice3tt;
        public static TechType _juice4tt;
        public static TechType _cake1tt;
        public static TechType _cake2tt;
        public static TechType _cake3tt;
        public static TechType _cake4tt;

        public static TechType techType;

        private static string type;
        private static string name;

        public static List<Ingredient> ingredientss = new List<Ingredient>();

        public static TechData techData;

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
                var prefabpath = internal_name;
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
                techType = TechTypeHandler.AddTechType(internal_name, _name, _tooltip + Cfg._tooltipsuffix);
                if (name == "Juice1")
                {
                    _juice1tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice1));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/juice1.png"))));
                }
                if (name == "Juice2")
                {
                    _juice2tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice2));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/juice2.png"))));
                }
                if (name == "Juice3")
                {
                    _juice3tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice3));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/juice3.png"))));
                }
                if (name == "Juice4")
                {
                    _juice4tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Juice4));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/juice4.png"))));
                }
                if (name == "Cake1")
                {
                    _cake1tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake1));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/cake1.png"))));
                }
                if (name == "Cake2")
                {
                    _cake2tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake2));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/cake2.png"))));
                }
                if (name == "Cake3")
                {
                    _cake3tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake3));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/cake3.png"))));
                }
                if (name == "Cake4")
                {
                    _cake4tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetGameObject.Cake4));
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, new Atlas.Sprite(ImageUtils.LoadTextureFromFile("./QMods/CustomFood2/Assets/cake4.png"))));
                }
                ApplyTechData();
                if (type == "Cakes")
                {
                    var CakeSprite = SpriteManager.Get(TechType.NutrientBlock);
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Cakes", "Cakes", CakeSprite, "Survival");
                    CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType, "Survival", "Cakes");
                    CraftDataHandler.AddToGroup(TechGroup.Survival, TechCategory.CuredFood, techType);
                }
                if (type == "Juices")
                {
                    var JuiceSprite = SpriteManager.Get(TechType.FilteredWater);
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Juices", "Juices", JuiceSprite, "Survival");
                    CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType, "Survival", "Juices");
                    CraftDataHandler.AddToGroup(TechGroup.Survival, TechCategory.Water, techType);
                }
                CraftDataHandler.SetItemSize(techType, new Vector2int(_x, _y));
                ingredientss.Clear();
                Log.Debug("Finished loading " + name);
            }
            catch (Exception e)
            {
                Log.e(e);
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
                    ingredientss.Add(new Ingredient((TechType)Enum.Parse(typeof(TechType), item), amount));
                }
            }
            else
            {
                Log.Debug(name, $"Ingredient {ingNo} is disabled. Ignoring...");
            }
        }
        public static void ApplyTechData()
        {
            if (ingredientss.Count == 0)
            {
                Log.Warning(name, "The item has no valid ingredients and will not be able to be crafted!");
            }
            if (ingredientss.Count == 1)
            {
                techData = new TechData
                {
                    craftAmount = 1,
                    Ingredients = new List<Ingredient>()
                    {
                        ingredientss.GetLast()
                    }
                };
            }
            if (ingredientss.Count == 2)
            {
                var i1 = ingredientss.GetLast();
                ingredientss.Remove(i1);

                techData = new TechData
                {
                    craftAmount = 1,
                    Ingredients = new List<Ingredient>()
                    {
                        i1,
                        ingredientss.GetLast()
                    }
                };
            }
            if (ingredientss.Count == 3)
            {
                var i1 = ingredientss.GetLast();
                ingredientss.Remove(i1);
                var i2 = ingredientss.GetLast();
                ingredientss.Remove(i2);

                techData = new TechData
                {
                    craftAmount = 1,
                    Ingredients = new List<Ingredient>()
                    {
                        i1,
                        i2,
                        ingredientss.GetLast()
                    }
                };
            }
            if (ingredientss.Count == 4)
            {
                var i1 = ingredientss.GetLast();
                ingredientss.Remove(i1);
                var i2 = ingredientss.GetLast();
                ingredientss.Remove(i2);
                var i3 = ingredientss.GetLast();
                ingredientss.Remove(i3);

                techData = new TechData
                {
                    craftAmount = 1,
                    Ingredients = new List<Ingredient>()
                    {
                        i1,
                        i2,
                        i3,
                        ingredientss.GetLast()
                    }
                };
            }
            if (ingredientss.Count == 5)
            {
                var i1 = ingredientss.GetLast();
                ingredientss.Remove(i1);
                var i2 = ingredientss.GetLast();
                ingredientss.Remove(i2);
                var i3 = ingredientss.GetLast();
                ingredientss.Remove(i3);
                var i4 = ingredientss.GetLast();
                ingredientss.Remove(i4);

                techData = new TechData
                {
                    craftAmount = 1,
                    Ingredients = new List<Ingredient>()
                    {
                        i1,
                        i2,
                        i3,
                        i4,
                        ingredientss.GetLast()
                    }
                };
            }
            CraftDataHandler.SetTechData(techType, techData);
        }
    }
}
