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

namespace EggInfo
{
    public class QPatch
    {
        private static readonly ConfigFile Config = new ConfigFile("config");

        private static string _egg1_tooltip = "tooltip1";
        private static string _egg2_tooltip = "tooltip2";
        private static string _egg3_tooltip = "tooltip3";
        private static string _egg4_tooltip = "tooltip4";
        private static string _egg5_tooltip = "tooltip5";
        private static string _egg6_tooltip = "tooltip6";
        private static string _egg7_tooltip = "tooltip7";
        private static string _egg8_tooltip = "tooltip8";
        private static string _egg9_tooltip = "tooltip9";
        private static string _egg10_tooltip = "tooltip10";
        private static string _egg11_tooltip = "tooltip11";
        private static string _egg12_tooltip = "tooltip12";
        private static string _egg13_tooltip = "tooltip13";
        private static string _egg14_tooltip = "tooltip14";
        private static string _egg15_tooltip = "tooltip15";
        private static string _egg16_tooltip = "tooltip16";

        public static TechType egg1tt;
        public static TechType egg2tt;
        public static TechType egg3tt;
        public static TechType egg4tt;
        public static TechType egg5tt;
        public static TechType egg6tt;
        public static TechType egg7tt;
        public static TechType egg8tt;
        public static TechType egg9tt;
        public static TechType egg10tt;
        public static TechType egg11tt;
        public static TechType egg12tt;
        public static TechType egg13tt;
        public static TechType egg14tt;
        public static TechType egg15tt;
        public static TechType egg16tt;

        public static string filePath = @"./QMods/EggInfo/Config.json";

        public static void Patch()
        {
            Config.Load();
            var configChanged =
            Config.TryGet(ref _egg1_tooltip, "BonesharkEgg", "TooltipHere")
            | Config.TryGet(ref _egg2_tooltip, "CrabsnakeEgg", "TooltipHere")
            | Config.TryGet(ref _egg3_tooltip, "CrabsquidEgg", "TooltipHere")
            | Config.TryGet(ref _egg4_tooltip, "CrashfishEgg", "TooltipHere")
            | Config.TryGet(ref _egg5_tooltip, "GasopodEgg", "TooltipHere")
            | Config.TryGet(ref _egg6_tooltip, "JellyrayEgg", "TooltipHere")
            | Config.TryGet(ref _egg7_tooltip, "LavaLizardEgg", "TooltipHere")
            | Config.TryGet(ref _egg8_tooltip, "MesmerEgg", "TooltipHere")
            | Config.TryGet(ref _egg9_tooltip, "RabbitRayEgg", "TooltipHere")
            | Config.TryGet(ref _egg10_tooltip, "SandsharkEgg", "TooltipHere")
            | Config.TryGet(ref _egg11_tooltip, "ShockerEgg", "TooltipHere")
            | Config.TryGet(ref _egg12_tooltip, "SpadefishEgg", "TooltipHere")
            | Config.TryGet(ref _egg13_tooltip, "StalkerEgg", "TooltipHere")
            | Config.TryGet(ref _egg14_tooltip, "CutefishEgg", "TooltipHere")
            | Config.TryGet(ref _egg15_tooltip, "ReefbackEgg", "TooltipHere")
            | Config.TryGet(ref _egg16_tooltip, "JumperEgg", "TooltipHere");

            if (_egg1_tooltip == "")
            {
                _egg1_tooltip = "tooltip1";
                Config["BonesharkEgg", "TooltipHere"] = _egg1_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip1", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg2_tooltip == "")
            {
                _egg2_tooltip = "tooltip2";
                Config["CrabsnakeEgg", "TooltipHere"] = _egg2_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip2", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg3_tooltip == "")
            {
                _egg3_tooltip = "tooltip3";
                Config["CrabsquidEgg", "TooltipHere"] = _egg3_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip3", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg4_tooltip == "")
            {
                _egg4_tooltip = "tooltip4";
                Config["CrashfishEgg", "TooltipHere"] = _egg4_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip4", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg5_tooltip == "")
            {
                _egg5_tooltip = "tooltip5";
                Config["GasopodEgg", "TooltipHere"] = _egg5_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip5", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg6_tooltip == "")
            {
                _egg6_tooltip = "tooltip6";
                Config["JellyrayEgg", "TooltipHere"] = _egg6_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip6", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg7_tooltip == "")
            {
                _egg7_tooltip = "tooltip7";
                Config["LavaLizardEgg", "TooltipHere"] = _egg7_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip7", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg8_tooltip == "")
            {
                _egg8_tooltip = "tooltip8";
                Config["MesmerEgg", "TooltipHere"] = _egg8_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip8", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg9_tooltip == "")
            {
                _egg9_tooltip = "tooltip9";
                Config["RabbitRayEgg", "TooltipHere"] = _egg9_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip9", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg10_tooltip == "")
            {
                _egg10_tooltip = "tooltip10";
                Config["SandsharkEgg", "TooltipHere"] = _egg10_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip10", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg11_tooltip == "")
            {
                _egg11_tooltip = "tooltip11";
                Config["ShockerEgg", "TooltipHere"] = _egg11_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip11", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg12_tooltip == "")
            {
                _egg12_tooltip = "tooltip12";
                Config["SpadefishEgg", "TooltipHere"] = _egg12_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip12", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg13_tooltip == "")
            {
                _egg13_tooltip = "tooltip13";
                Config["StalkerEgg", "TooltipHere"] = _egg13_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip13", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg14_tooltip == "")
            {
                _egg14_tooltip = "tooltip14";
                Config["CutefishEgg", "TooltipHere"] = _egg14_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip14", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg15_tooltip == "")
            {
                _egg15_tooltip = "tooltip15";
                Config["ReefbackEgg", "TooltipHere"] = _egg15_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip15", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (_egg16_tooltip == "")
            {
                _egg16_tooltip = "tooltip16";
                Config["JumperEgg", "TooltipHere"] = _egg16_tooltip;
                Utilites.Logger.Logger.Error("TooltipHere was set to tooltip16", Utilites.Logger.LogType.Custom | Utilites.Logger.LogType.Console);
                configChanged = true;
            }
            if (configChanged)
            {
                Config.Save();
            }

            //BonesharkEgg
            Logger.Log("Started Patching BonesharkEgg");
            egg1tt = TechTypePatcher.AddTechType("Boneshark Egg", "Boneshark Egg", _egg1_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg1tt);
            KnownTechPatcher.unlockedAtStart.Add(egg1tt);

            var egg1sprite = SpriteManager.Get(TechType.BonesharkEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg1tt, egg1sprite));

            //CrabsnakeEgg
            Logger.Log("Started Patching CrabsnakeEgg");
            egg2tt = TechTypePatcher.AddTechType("Crabsnake Egg", "Crabsnake Egg", _egg2_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg2tt);
            KnownTechPatcher.unlockedAtStart.Add(egg2tt);

            var egg2sprite = SpriteManager.Get(TechType.CrabsnakeEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg2tt, egg2sprite));

            //CrabsquidEgg
            Logger.Log("Started Patching CrabsquidEgg");
            egg3tt = TechTypePatcher.AddTechType("Crabsquid Egg", "Crabsquid Egg", _egg3_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg3tt);
            KnownTechPatcher.unlockedAtStart.Add(egg3tt);

            var egg3sprite = SpriteManager.Get(TechType.CrabsquidEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg3tt, egg3sprite));

            //CrashfishEgg
            Logger.Log("Started Patching CrashfishEgg");
            egg4tt = TechTypePatcher.AddTechType("Crashfish Egg", "Crashfish Egg", _egg4_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg4tt);
            KnownTechPatcher.unlockedAtStart.Add(egg4tt);

            var egg4sprite = SpriteManager.Get(TechType.CrashEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg4tt, egg4sprite));

            //GasopodEgg
            Logger.Log("Started Patching GasopodEgg");
            egg5tt = TechTypePatcher.AddTechType("Gasopod Egg", "Gasopod Egg", _egg5_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg5tt);
            KnownTechPatcher.unlockedAtStart.Add(egg5tt);

            var egg5sprite = SpriteManager.Get(TechType.GasopodEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg5tt, egg5sprite));

            //JellyrayEgg
            Logger.Log("Started Patching JellyrayEgg");
            egg6tt = TechTypePatcher.AddTechType("Jellyray Egg", "Jellyray Egg", _egg6_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg6tt);
            KnownTechPatcher.unlockedAtStart.Add(egg6tt);

            var egg6sprite = SpriteManager.Get(TechType.JellyrayEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg6tt, egg6sprite));

            //LavaLizardEgg
            Logger.Log("Started Patching LavaLizardEgg");
            egg7tt = TechTypePatcher.AddTechType("Lavalizard Egg", "Lavalizard Egg", _egg7_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg7tt);
            KnownTechPatcher.unlockedAtStart.Add(egg7tt);

            var egg7sprite = SpriteManager.Get(TechType.LavaLizardEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg7tt, egg7sprite));

            //MesmerEgg
            Logger.Log("Started Patching MesmerEgg");
            egg8tt = TechTypePatcher.AddTechType("Mesmer Egg", "Mesmer Egg", _egg8_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg8tt);
            KnownTechPatcher.unlockedAtStart.Add(egg8tt);

            var egg8sprite = SpriteManager.Get(TechType.MesmerEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg8tt, egg8sprite));

            //RabbitRayEgg
            Logger.Log("Started Patching RabbitRayEgg");
            egg9tt = TechTypePatcher.AddTechType("Rabbitray Egg", "Rabbitray Egg", _egg9_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg9tt);
            KnownTechPatcher.unlockedAtStart.Add(egg9tt);

            var egg9sprite = SpriteManager.Get(TechType.RabbitrayEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg9tt, egg9sprite));

            //SandsharkEgg
            Logger.Log("Started Patching SandsharkEgg");
            egg10tt = TechTypePatcher.AddTechType("Sandshark Egg", "Sandshark Egg", _egg10_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg10tt);
            KnownTechPatcher.unlockedAtStart.Add(egg10tt);

            var egg10sprite = SpriteManager.Get(TechType.SandsharkEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg10tt, egg10sprite));

            //ShockerEgg
            Logger.Log("Started Patching ShockerEgg");
            egg11tt = TechTypePatcher.AddTechType("Shocker Egg", "Shocker Egg", _egg11_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg11tt);
            KnownTechPatcher.unlockedAtStart.Add(egg11tt);

            var egg11sprite = SpriteManager.Get(TechType.ShockerEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg11tt, egg11sprite));

            //SpadefishEgg
            Logger.Log("Started Patching SpadefishEgg");
            egg12tt = TechTypePatcher.AddTechType("Spadefish Egg", "Spadefish Egg", _egg12_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg12tt);
            KnownTechPatcher.unlockedAtStart.Add(egg12tt);

            var egg12sprite = SpriteManager.Get(TechType.SpadefishEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg12tt, egg12sprite));

            //StalkerEgg
            Logger.Log("Started Patching StalkerEgg");
            egg13tt = TechTypePatcher.AddTechType("Stalker Egg", "Stalker Egg", _egg13_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg13tt);
            KnownTechPatcher.unlockedAtStart.Add(egg13tt);

            var egg13sprite = SpriteManager.Get(TechType.StalkerEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg13tt, egg13sprite));

            //CutefishEgg
            Logger.Log("Started Patching CutefishEgg");
            egg14tt = TechTypePatcher.AddTechType("Cutefish Egg", "Cutefish Egg", _egg14_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg14tt);
            KnownTechPatcher.unlockedAtStart.Add(egg14tt);

            var egg14sprite = SpriteManager.Get(TechType.CutefishEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg14tt, egg14sprite));

            //ReefbackEgg
            Logger.Log("Started Patching ReefbackEgg");
            egg15tt = TechTypePatcher.AddTechType("Reefback Egg", "Reefback Egg", _egg15_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg15tt);
            KnownTechPatcher.unlockedAtStart.Add(egg15tt);

            var egg15sprite = SpriteManager.Get(TechType.ReefbackEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg15tt, egg15sprite));

            //JumperEgg
            Logger.Log("Started Patching JumperEgg");
            egg16tt = TechTypePatcher.AddTechType("Jumper Egg", "Jumper Egg", _egg16_tooltip);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Resources, TechCategory.AdvancedMaterials, egg16tt);
            KnownTechPatcher.unlockedAtStart.Add(egg16tt);

            var egg16sprite = SpriteManager.Get(TechType.JumperEgg);
            CustomSpriteHandler.customSprites.Add(new CustomSprite(egg16tt, egg16sprite));
        }
    }
}