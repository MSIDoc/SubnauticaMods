using SMLHelper.Patchers;
using System;
using System.Collections.Generic;
using Console = Colorful.Console;

namespace JsonEditor.Data.Scripts.Utilitary
{
    public class Ingredients
    {
        public static List<IngredientHelper> ingredients = new List<IngredientHelper>();

        public static void CheckIngredients(string item, int amount)
        {
            if ((amount != 0) && (item != "None"))
            {
                if (Enum.IsDefined(typeof(TechType), item))
                {
                    ingredients.Add(new IngredientHelper((TechType)Enum.Parse(typeof(TechType), item), amount));
                }
            }
        }
        public static void ParseIngredients(string item, int amount)
        {
            if ((amount != 0) && (item != "None"))
            {
                if (Enum.IsDefined(typeof(TechType), item))
                {
                    ingredients.Add(new IngredientHelper((TechType)Enum.Parse(typeof(TechType), item), amount));
                }
            }
        }
    }
}
