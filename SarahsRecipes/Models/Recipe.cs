using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SarahsRecipes.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<Ingredient>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Preparation Time")]
        public string PrepTime { get; set; }
        [Display(Name = "Cook Time")]
        public string CookTime { get; set; }
        [Display(Name = "Servings")]
        public int Serves { get; set; }
        public string Category { get; set; }
        [Display(Name = "Sub-Category")]
        public string SubCat { get; set; }
        public Boolean Hot { get; set; }
        public string Protein { get; set; }
        public string Meal { get; set; }
        public string Directions { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }
    }


}