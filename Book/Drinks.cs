using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Drinks
    {
        public string RecipeName { get; set; }

        public string RecipeType { get; set; }

        public string RecipeIngredients { get; set; }

        public string RecipeInfo { get; set; }

         
        
        public Drinks()
        {

        }

        public Drinks(string name, string type, string ingredients, string info)
        {
            RecipeName = name;
            RecipeType = type;
            RecipeIngredients = ingredients;
            RecipeInfo = info;
        }

        public override string ToString()
        {
            return "RecipeName:" + RecipeName + "Recipetype:" + RecipeType + "RecipeIngredients:" + RecipeIngredients + "RecipeInfo" + RecipeInfo;
        }
    }
}
