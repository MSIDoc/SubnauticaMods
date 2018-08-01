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

namespace CustomFood2
{
    public class GetGameObject
    {
        public static GameObject Main(TechType techtype, string internalname, int food, int water, string prefabpath)
        {
            var prefab = Resources.Load<GameObject>("WorldEntities/Food/" + prefabpath);
            var obj = UnityEngine.Object.Instantiate(prefab);

            var identifier = obj.GetComponent<PrefabIdentifier>();
            var techTag = obj.GetComponent<TechTag>();
            var eatable = obj.GetComponent<Eatable>();

            identifier.ClassId = internalname;
            techTag.type = techtype;
            eatable.foodValue = food;
            eatable.waterValue = water;

            return obj;
        }
        public static GameObject MainJuice(TechType techtype, string internalname, int food, int water)
        {
            return Main(techtype, internalname, food, water, "FilteredWater");
        }
        public static GameObject MainCake(TechType techtype, string internalname, int food, int water)
        {
            return Main(techtype, internalname, food, water, "NutrientBlock");
        }
        public static GameObject Juice1()
        {
            return MainJuice(LoadItem._juice1tt, "CustomJuice1", Cfg._juice1_foodvalue, Cfg._juice1_watervalue);
        }
        public static GameObject Juice2()
        {
            return MainJuice(LoadItem._juice2tt, "CustomJuice2", Cfg._juice2_foodvalue, Cfg._juice2_watervalue);
        }
        public static GameObject Juice3()
        {
            return MainJuice(LoadItem._juice3tt, "CustomJuice3", Cfg._juice3_foodvalue, Cfg._juice3_watervalue);
        }
        public static GameObject Juice4()
        {
            return MainJuice(LoadItem._juice4tt, "CustomJuice4", Cfg._juice4_foodvalue, Cfg._juice4_watervalue);
        }
        public static GameObject Cake1()
        {
            return MainCake(LoadItem._cake1tt, "CustomCake1", Cfg._cake1_foodvalue, Cfg._cake1_watervalue);
        }
        public static GameObject Cake2()
        {
            return MainCake(LoadItem._cake2tt, "CustomCake2", Cfg._cake2_foodvalue, Cfg._cake2_watervalue);
        }
        public static GameObject Cake3()
        {
            return MainCake(LoadItem._cake3tt, "CustomCake3", Cfg._cake3_foodvalue, Cfg._cake3_watervalue);
        }
        public static GameObject Cake4()
        {
            return MainCake(LoadItem._cake4tt, "CustomCake4", Cfg._cake4_foodvalue, Cfg._cake4_watervalue);
        }
    }
}
