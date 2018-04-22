using System;
using SMLHelper;
using SMLHelper.Patchers;

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
                CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Juices", "Juices", CraftScheme.Fabricator, Cfg.juice_default));
                CraftTreePatcher.customTabs.Add(new CustomCraftTab("Survival/Cakes", "Cakes", CraftScheme.Fabricator, Cfg.cake_default));
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}
