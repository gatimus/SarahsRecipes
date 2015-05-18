using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SarahsRecipes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int RecipesId { get; set; }
        public string Name { get; set; }
        public Nullable<double> Qty { get; set; }
        public string Unit { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}