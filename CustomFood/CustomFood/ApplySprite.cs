using SMLHelper;

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
            if (_sprite == "Blue")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_blue));
                return;
            }
            if (_sprite == "BlueGreen")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_bluegreen));
                return;
            }
            if (_sprite == "Green")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_green));
                return;
            }
            if (_sprite == "LightBlue")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_lightblue));
                return;
            }
            if (_sprite == "Orange")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_orange));
                return;
            }
            if (_sprite == "Pink")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_pink));
                return;
            }
            if (_sprite == "Purple")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_purple));
                return;
            }
            if (_sprite == "Red")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_red));
                return;
            }
            if (_sprite == "Yellow")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_yellow));
                return;
            }
            CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.cake_default));
        }
        /// <summary>
        /// Applying juice sprites
        /// </summary>
        /// <param name="techType">TechType</param>
        /// <param name="_sprite">Sprite name</param>
        public static void Juice(TechType techType, string _sprite)
        {
            if (_sprite == "Blue")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_blue));
                return;
            }
            if (_sprite == "BlueGreen")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_bluegreen));
                return;
            }
            if (_sprite == "Green")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_green));
                return;
            }
            if (_sprite == "LightBlue")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_lightblue));
                return;
            }
            if (_sprite == "Orange")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_orange));
                return;
            }
            if (_sprite == "Pink")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_pink));
                return;
            }
            if (_sprite == "Purple")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_purple));
                return;
            }
            if (_sprite == "Red")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_red));
                return;
            }
            if (_sprite == "Yellow")
            {
                CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_yellow));
                return;
            }
            CustomSpriteHandler.customSprites.Add(new CustomSprite(techType, Cfg.juice_default));
        }
    }
}
