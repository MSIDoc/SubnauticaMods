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
    public class GetGameObject
    {
        public static GameObject Juice1()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = UnityEngine.Object.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice1";
            techTag.type = LoadItem._juice1tt;
            eatable.foodValue = Cfg._juice1_foodvalue;
            eatable.waterValue = Cfg._juice1_watervalue;

            return obj;
        }
        public static GameObject Juice2()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = UnityEngine.Object.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice2";
            techTag.type = LoadItem._juice2tt;
            eatable.foodValue = Cfg._juice2_foodvalue;
            eatable.waterValue = Cfg._juice2_watervalue;
            
            return obj;
        }
        /// <summary>
        /// Juice3 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject Juice3()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = UnityEngine.Object.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice3";
            techTag.type = LoadItem._juice3tt;
            eatable.foodValue = Cfg._juice3_foodvalue;
            eatable.waterValue = Cfg._juice3_watervalue;

            return obj;
        }
        /// <summary>
        /// Juice4 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject Juice4()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice4";
            techTag.type = LoadItem._juice4tt;
            eatable.foodValue = Cfg._juice4_foodvalue;
            eatable.waterValue = Cfg._juice4_watervalue;
            return obj;
        }
        /// <summary>
        /// Juice5 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject Juice5()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice5";
            techTag.type = LoadItem._juice5tt;
            eatable.foodValue = Cfg._juice5_foodvalue;
            eatable.waterValue = Cfg._juice5_watervalue;
            return obj;
        }
        /// <summary>
        /// Juice6 gameobject
        /// </summary>
        /// <returns>Returns the object</returns>
        public static GameObject Juice6()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/FilteredWater");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomJuice6";
            techTag.type = LoadItem._juice6tt;
            eatable.foodValue = Cfg._juice6_foodvalue;
            eatable.waterValue = Cfg._juice6_watervalue;
            return obj;
        }
        public static GameObject Cake1()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomCake1";
            techTag.type = LoadItem._cake1tt;
            eatable.foodValue = Cfg._cake1_foodvalue;
            eatable.waterValue = Cfg._cake1_watervalue;

            return obj;
        }
        public static GameObject Cake2()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomCake2";
            techTag.type = LoadItem._cake2tt;
            eatable.foodValue = Cfg._cake2_foodvalue;
            eatable.waterValue = Cfg._cake2_watervalue;

            return obj;
        }
        public static GameObject Cake3()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomCake3";
            techTag.type = LoadItem._cake3tt;
            eatable.foodValue = Cfg._cake3_foodvalue;
            eatable.waterValue = Cfg._cake3_watervalue;

            return obj;
        }
        public static GameObject Cake4()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = UnityEngine.Object.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomCake4";
            techTag.type = LoadItem._cake4tt;
            eatable.foodValue = Cfg._cake4_foodvalue;
            eatable.waterValue = Cfg._cake4_watervalue;

            return obj;
        }
        public static GameObject Cake5()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomCake5";
            techTag.type = LoadItem._cake5tt;
            eatable.foodValue = Cfg._cake5_foodvalue;
            eatable.waterValue = Cfg._cake5_watervalue;

            return obj;
        }
        public static GameObject Cake6()
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/NutrientBlock");
            var obj = GameObject.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = "CustomCake6";
            techTag.type = LoadItem._cake6tt;
            eatable.foodValue = Cfg._cake6_foodvalue;
            eatable.waterValue = Cfg._cake6_watervalue;

            return obj;
        }
    }
}
