using System;

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

                LoadFabricatorTabs.Load();

                LoadItem.DummySpriteTechTypes();

                LoadItem.Load("Juice", 1);
                LoadItem.Load("Juice", 2);
                LoadItem.Load("Juice", 3);
                LoadItem.Load("Juice", 4);
                LoadItem.Load("Juice", 5);
                LoadItem.Load("Juice", 6);
                LoadItem.Load("Juice", 7);
                LoadItem.Load("Juice", 8);
                LoadItem.Load("Cake", 1);
                LoadItem.Load("Cake", 2);
                LoadItem.Load("Cake", 3);
                LoadItem.Load("Cake", 4);
                LoadItem.Load("Cake", 5);
                LoadItem.Load("Cake", 6);
                LoadItem.Load("Cake", 7);
                LoadItem.Load("Cake", 8);

                Log.Info("Finished loading");
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}