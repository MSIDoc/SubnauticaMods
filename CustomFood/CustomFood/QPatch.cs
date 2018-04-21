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
    /// <summary>
    /// Main class
    /// </summary>
    public class QPatch
    {
        /// <summary>
        /// Entry point
        /// </summary>
        public static void Patch()
        {
            try
            {
                Log.Info("Started loading");
                Cfg.Init();
                LoadItem.DummySpriteTechTypes();
                LoadFabricatorTabs.Load();
                LoadItem.Load("Juice", 1, "WorldEntities/Food/juice1");
                LoadItem.Load("Juice", 2, "WorldEntities/Food/juice2");
                LoadItem.Load("Juice", 3, "WorldEntities/Food/juice3");
                LoadItem.Load("Juice", 4, "WorldEntities/Food/juice4");
                LoadItem.Load("Juice", 5, "WorldEntities/Food/juice5");
                LoadItem.Load("Juice", 6, "WorldEntities/Food/juice6");
                LoadItem.Load("Cake", 1, "WorldEntities/Food/CustomCake1");
                LoadItem.Load("Cake", 2, "WorldEntities/Food/CustomCake2");
                LoadItem.Load("Cake", 3, "WorldEntities/Food/CustomCake3");
                LoadItem.Load("Cake", 4, "WorldEntities/Food/CustomCake4");
                LoadItem.Load("Cake", 5, "WorldEntities/Food/CustomCake5");
                LoadItem.Load("Cake", 6, "WorldEntities/Food/CustomCake6");
                
                Log.Info("Finished loading");
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}