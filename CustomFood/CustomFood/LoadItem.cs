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

        public static TechType techType;

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
                if (_enabled == false)
                {
                    return;
                }
                if (_name == "")
                {
                    _name = "Name can't be blank";
                    Config[type, name, "Name"] = _name;
                    Log.Warning(name, "Name can't be blank");
                    Log.Info(name, "Name was set to \"Name can't be blank\"");
                }
                if (_foodvalue < 1)
                {
                    _foodvalue = 1;
                    Config[type, name, "Values", "Food"] = _foodvalue;
                    Log.Warning(name, "Food value can't be blank");
                    Log.Info(name, "Food value was set to 1");
                }
                if (_watervalue < 1)
                {
                    _watervalue = 1;
                    Config[type, name, "Values", "Water"] = _watervalue;
                    Log.Warning(name, "Water value can't be blank");
                    Log.Info(name, "Water value was set to 1");
                }
                if (!Enum.IsDefined(typeof(TechType), _ingredient1))
                {
                    _ingredient1 = "Ingredient 1 invalid";
                    Config[type, name, "Ingredients", "Ingredient1", "Item"] = _ingredient1;
                    Log.Warning(name, "Ingredient1 must be a TechType");
                    Log.Info(name, "Ingredient1 was set to a dummy value");
                    var _ttt1 = Cfg._ingredient1missing;
                }
                else
                {
                    Log.Info("Before parse: " + _ingredient1);
                    _ttt1 = (TechType)Enum.Parse(typeof(TechType), _ingredient1);
                    Log.Info("After parse: " + _ttt1);
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
                    var _ttt2 = Cfg._ingredient2missing;
                }
                else
                {
                    Log.Info("Before parse: " + _ingredient2);
                    _ttt2 = (TechType)Enum.Parse(typeof(TechType), _ingredient2);
                    Log.Info("After parse: " + _ttt2);
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
                Cfg.Save();
                techType = TechTypePatcher.AddTechType(internal_name, _name, _tooltip + Cfg._tooltipsuffix);
                Log.Debug("Started patching " + name);
                if (name == "Juice1")
                {
                    var juice1tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetJuice1Bottle));
                }
                if (name == "Juice2")
                {
                    var juice2tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetJuice2Bottle));
                }
                if (name == "Juice3")
                {
                    var juice3tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetJuice2Bottle));
                }
                if (name == "Juice4")
                {
                    var juice4tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetJuice2Bottle));
                }
                if (name == "Juice5")
                {
                    var juice5tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetJuice2Bottle));
                }
                if (name == "Juice6")
                {
                    var juice6tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetJuice2Bottle));
                }
                if (name == "Cake1")
                {
                    var cake1tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetCustomCake1Bottle));
                }
                if (name == "Cake2")
                {
                    var cake2tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetCustomCake2Bottle));
                }
                if (name == "Cake3")
                {
                    var cake3tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetCustomCake3Bottle));
                }
                if (name == "Cake4")
                {
                    var cake4tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetCustomCake4Bottle));
                }
                if (name == "Cake5")
                {
                    var cake5tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetCustomCake5Bottle));
                }
                if (name == "Cake6")
                {
                    var cake6tt = techType;
                    CustomPrefabHandler.customPrefabs.Add(new CustomPrefab(
                        internal_name,
                        prefabpath,
                        techType,
                        GetResource.GetCustomCake6Bottle));
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
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(techType, CraftScheme.Fabricator, "Survival/Cakes/" + internal_name));
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.CuredFood, techType);
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.CakesSprite));
                }
                if (type == "Juices")
                {
                    CraftTreePatcher.customNodes.Add(new CustomCraftNode(techType, CraftScheme.Fabricator, "Survival/Juices/" + internal_name));
                    CraftDataPatcher.AddToCustomGroup(TechGroup.Survival, TechCategory.Water, techType);
                    CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.JuiceSprite));
                }
                CraftDataPatcher.customItemSizes[key: techType] = new Vector2int(_x, _y);
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}
