using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeShared.Model
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeText { get; set;}
        public int TimeToCook { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
