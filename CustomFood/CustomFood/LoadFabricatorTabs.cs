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
    /// Main class for loading the fabricator tabs
    /// </summary>
    public class LoadFabricatorTabs
    {
        /// <summary>
        /// Loads the fabricator tabs
        /// </summary>
        public static void Load()
        {
            try
            {
                CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Juices", "Juices", CraftScheme.Fabricator, Cfg.JuiceSprite));
                CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Cakes", "Cakes", CraftScheme.Fabricator, Cfg.CakesSprite));
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}
