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
    /// Main class for loading items
    /// </summary>
    public class LoadItem
    {
        public static TechType _ttt1;
        public static TechType _ttt2;
        public static TechType _juice1tt;
        public static TechType _juice2tt;
        public static TechType _juice3tt;
        public static TechType _juice4tt;
        public static TechType _juice5tt;
        public static TechType _juice6tt;
        public static TechType _cake1tt;
        public static TechType _cake2tt;
        public static TechType _cake3tt;
        public static TechType _cake4tt;
        public static TechType _cake5tt;
        public static TechType _cake6tt;
        public static TechType techType;
        public static string _sprite;

        /// <summary>
        /// Loads an item
        /// </summary>
        /// <param name="typ">Must be "Juice" or "Cake"</param>
        /// <param name="numbr">Must be between 1 and 6</param>
        /// <param name="prefabpath">The Prefab path</param>
        public static void Load(string typ, int numbr, string prefabpath)
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
                var _x = 1;
                var _y = 1;
                var Config = Cfg.Config;
                var number = numbr.ToString();
                var type = typ + "s";
                var name = typ + number;
                var internal_name = "Custom" + name;
                var _sprite = "Default";
                Config.TryGet(ref _enabled, type, name, "Enabled");
                Config.TryGet(ref _name, type, name, "Name");
                Config.TryGet(ref _tooltip, type, name, "Tooltip");
                Config.TryGet(ref _foodvalue, type, name, "Values", "Food");
                Config.TryGet(ref _watervalue, type, name, "Values", "Water");
                Config.TryGet(ref _ingredient1, type, name, "Ingredients", "Ingredient1", "Item");
                Config.TryGet(ref _ingredient1amount, type, name, "Ingredients", "Ingredient1", "Amount");
                Config.TryGet(ref _ingredient2, type, name, "Ingredients", "Ingredient2", "Item");
                Config.TryGet(ref _ingredient2amount, type, name, "Ingredients", "Ingredient2", "Amount");
                Config.TryGet(ref _x, type, name, "Size", "X");
                Config.TryGet(ref _y, type, name, "Size", "Y");
                Config.TryGet(ref _sprite, type, name, "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'");
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
                if (!Enum.IsDefined(typeof(TechType), _ingredient1))
                {
                    _ingredient1 = "Ingredient 1 invalid";
                    Config[type, name, "Ingredients", "Ingredient1", "Item"] = _ingredient1;
                    Log.Warning(name, "Ingredient1 must be a TechType");
                    Log.Info(name, "Ingredient1 was set to a dummy value");
                    _ttt1 = Cfg._ingredient1missing;
                }
                else
                {
                    _ttt1 = (TechType)Enum.Parse(typeof(TechType), _ingredient1);
                }
                if (_ingredient1amount < 1)
                {
                    _ingredient1amount = 1;
                    Config[type, name, "Ingredients", "Ingredient1", "Amount"] = _ingredient1amount;
                    Log.Warning(name, "Ingredient1 amount must not be less than 1");
                    Log.Info(name, "Ingredient1 amount was set to 1");
                }
                if (!Enum.IsDefined(typeof(TechType), _ingredient2))
                {
                    _ingredient2 = "Ingredient 2 invalid";
                    Config[type, name, "Ingredients", "Ingredient2", "Item"] = _ingredient2;
                    Log.Warning(name, "Ingredient2 must be a TechType");
                    Log.Info(name, "Ingredient2 was set to a dummy value");
                    _ttt2 = Cfg._ingredient2missing;
                }
                else
                {
                    _ttt2 = (TechType)Enum.Parse(typeof(TechType), _ingredient2);
                }
                if (_ingredient2amount < 1)
                {
                    _ingredient2amount = 1;
                    Config[type, name, "Ingredients", "Ingredient2", "Amount"] = _ingredient2amount;
                    Log.Warning(name, "Ingredient2 amount must not be less than 1");
                    Log.Info(name, "Ingredient2 amount was set to 1");
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
                if (!Enum.IsDefined(typeof(Cfg.SpriteColor), _sprite))
                {
                    _sprite = "Default";
                    Config[type, name, "Icon color. Must be: 'Blue', 'BlueGreen', 'Green', 'LightBlue', 'Orange', 'Pink', 'Purple', 'Red', 'Yellow' or 'Default'"] = _sprite;
                    Log.Warning(name, "Sprite is invalid");
                    Log.Info(name, "Sprite was set to the default value");
                }
                Cfg.Save();
                techType = TechTypePatcher.AddTechType(internal_name, _name, _tooltip + Cfg._tooltipsuffix);
                Log.Debug("Started patching " + name);
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
                var techData = new TechDataHelper
                {
                    _craftAmount = 1,
                    _ingredients = new List<IngredientHelper>()
                {
                    new IngredientHelper(_ttt1, _ingredient1amount),
                    new IngredientHelper(_ttt2, _ingredient2amount)
                },
                    _techType = techType
                };
                CraftDataPatcher.customTechData.Add(techType, techData);
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

    }
}
