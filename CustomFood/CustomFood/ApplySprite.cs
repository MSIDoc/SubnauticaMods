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
    /// Main class for applying sprites
    /// </summary>
    public class ApplySprite
    {
        /// <summary>
        /// Applying cake sprites
        /// </summary>
        /// <param name="techType">TechType</param>
        /// <param name="_sprite">Sprite name</param>
        public static void Cake(TechType techType, string _sprite)
        {
            if (_sprite == "Default")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_default));
            if (_sprite == "Blue")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_blue));
            if (_sprite == "BlueGreen")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_bluegreen));
            if (_sprite == "Green")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_green));
            if (_sprite == "Orange")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_orange));
            if (_sprite == "Pink")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_pink));
            if (_sprite == "Purple")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_purple));
            if (_sprite == "Red")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_red));
            if (_sprite == "Yellow")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_yellow));
        }
        /// <summary>
        /// Applying juice sprites
        /// </summary>
        /// <param name="techType">TechType</param>
        /// <param name="_sprite">Sprite name</param>
        public static void Juice(TechType techType, string _sprite)
        {
            if (_sprite == "Default")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_default));
            if (_sprite == "Blue")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_blue));
            if (_sprite == "BlueGreen")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_bluegreen));
            if (_sprite == "Green")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_green));
            if (_sprite == "Orange")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_orange));
            if (_sprite == "Pink")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_pink));
            if (_sprite == "Purple")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_purple));
            if (_sprite == "Red")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_red));
            if (_sprite == "Yellow")
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_yellow));
        }
    }
}
