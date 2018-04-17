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
    /// Main class for obtaining gameobjects
    /// </summary>
    public class GetResource
    {
        /// <summary>
        /// Juice1 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject GetJuice1Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice1";
            techTag.type = LoadItem.juice1tt;
            eatable.foodValue = Cfg._juice1_foodvalue;
            eatable.waterValue = Cfg._juice1_watervalue;

            return obj;
        }
        /// <summary>
        /// Juice2 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject GetJuice2Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice2";
            techTag.type = LoadItem.juice2tt;
            eatable.foodValue = Cfg._juice2_foodvalue;
            eatable.waterValue = Cfg._juice2_watervalue;
            return obj;
        }
        /// <summary>
        /// Juice3 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject GetJuice3Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice3";
            techTag.type = LoadItem.juice3tt;
            eatable.foodValue = Cfg._juice3_foodvalue;
            eatable.waterValue = Cfg._juice3_watervalue;
            return obj;
        }
        /// <summary>
        /// Juice4 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject GetJuice4Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice4";
            techTag.type = LoadItem.juice4tt;
            eatable.foodValue = Cfg._juice4_foodvalue;
            eatable.waterValue = Cfg._juice4_watervalue;
            return obj;
        }
        /// <summary>
        /// Juice5 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject GetJuice5Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice5";
            techTag.type = LoadItem.juice5tt;
            eatable.foodValue = Cfg._juice5_foodvalue;
            eatable.waterValue = Cfg._juice5_watervalue;
            return obj;
        }
        /// <summary>
        /// Juice6 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject GetJuice6Bottle()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice6";
            techTag.type = LoadItem.juice6tt;
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

            identifier.ClassId = "CustomCake1";
            techTag.type = LoadItem.cake1tt;
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

            identifier.ClassId = "CustomCake2";
            techTag.type = LoadItem.cake2tt;
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

            identifier.ClassId = "CustomCake3";
            techTag.type = LoadItem.cake3tt;
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

            identifier.ClassId = "CustomCake4";
            techTag.type = LoadItem.cake4tt;
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

            identifier.ClassId = "CustomCake5";
            techTag.type = LoadItem.cake5tt;
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

            identifier.ClassId = "CustomCake6";
            techTag.type = LoadItem.cake6tt;
            eatable.foodValue = Cfg._cake6_foodvalue;
            eatable.waterValue = Cfg._cake6_watervalue;

            return obj;
        }
    }
}
