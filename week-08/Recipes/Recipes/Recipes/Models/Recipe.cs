﻿namespace Recipes.Models
{
    /// <summary>
    /// Data for one recipe.
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Primary Key for recipe.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the recipe.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The country from which the recipe originates.
        /// </summary>
        public int Cuisine { get; set; }
        /// <summary>
        /// The time in minutes that needed for the preparation.
        /// </summary>
        public int PreparationTimeInMinutes { get; set; }
        /// <summary>
        /// Shows how hard the recipe is to prepare.
        /// </summary>
        public int Level { get; set; } = 0;
        /// <summary>
        /// True if the recipe is vegetarian.
        /// </summary>
        public bool IsVegetarian { get; set; } = false;
    }
}
