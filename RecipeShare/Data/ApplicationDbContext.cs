using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using RecipeShare.Models;

namespace RecipeShare.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed some initial recipe data
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = 1,
                    Title = "Spaghetti Carbonara",
                    Description = "A classic Italian pasta dish with eggs, cheese, pancetta and black pepper.",
                    Ingredients = "400g spaghetti, 200g pancetta, 3 large eggs, 75g Pecorino Romano cheese, 50g Parmesan, black pepper",
                    Instructions = "1. Cook pasta until al dente.\n2. Fry pancetta until crisp.\n3. Beat eggs with cheese and pepper.\n4. Mix everything together off the heat.",
                    CookingTimeMinutes = 25,
                    Difficulty = DifficultyLevel.Intermediate,
                    ImageUrl = "/images/carbonara.jpg",
                    Category = "Pasta"
                },
                new Recipe
                {
                    Id = 2,
                    Title = "Avocado Toast",
                    Description = "Simple and nutritious breakfast option that's ready in minutes.",
                    Ingredients = "2 slices of bread, 1 ripe avocado, lemon juice, salt, pepper, red pepper flakes",
                    Instructions = "1. Toast bread until golden.\n2. Mash avocado with lemon juice, salt and pepper.\n3. Spread on toast and sprinkle with red pepper flakes.",
                    CookingTimeMinutes = 10,
                    Difficulty = DifficultyLevel.Beginner,
                    ImageUrl = "/images/avocado-toast.jpg",
                    Category = "Breakfast"
                },
                new Recipe
                {
                    Id = 3,
                    Title = "Chocolate Chip Cookies",
                    Description = "Classic homemade cookies that are crisp on the outside and chewy in the middle.",
                    Ingredients = "250g flour, 1/2 tsp baking soda, 170g melted butter, 100g white sugar, 200g brown sugar, 1 tsp vanilla, 1 egg, 1 egg yolk, 200g chocolate chips",
                    Instructions = "1. Mix dry ingredients.\n2. Cream butter and sugars, add eggs and vanilla.\n3. Combine with dry ingredients and fold in chocolate chips.\n4. Bake at 325°F for 15 minutes.",
                    CookingTimeMinutes = 25,
                    Difficulty = DifficultyLevel.Beginner,
                    ImageUrl = "/images/cookies.jpg",
                    Category = "Dessert"
                }
            );
        }
    }
}