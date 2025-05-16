using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipeShare.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: false),
                    Instructions = table.Column<string>(type: "TEXT", nullable: false),
                    CookingTimeMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    Difficulty = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "CookingTimeMinutes", "DateCreated", "Description", "Difficulty", "ImageUrl", "Ingredients", "Instructions", "Title" },
                values: new object[,]
                {
                    { 1, "Pasta", 25, new DateTime(2025, 5, 15, 22, 30, 34, 987, DateTimeKind.Local).AddTicks(2397), "A classic Italian pasta dish with eggs, cheese, pancetta and black pepper.", 1, "/images/carbonara.jpg", "400g spaghetti, 200g pancetta, 3 large eggs, 75g Pecorino Romano cheese, 50g Parmesan, black pepper", "1. Cook pasta until al dente.\n2. Fry pancetta until crisp.\n3. Beat eggs with cheese and pepper.\n4. Mix everything together off the heat.", "Spaghetti Carbonara" },
                    { 2, "Breakfast", 10, new DateTime(2025, 5, 15, 22, 30, 34, 987, DateTimeKind.Local).AddTicks(2424), "Simple and nutritious breakfast option that's ready in minutes.", 0, "/images/avocado-toast.jpg", "2 slices of bread, 1 ripe avocado, lemon juice, salt, pepper, red pepper flakes", "1. Toast bread until golden.\n2. Mash avocado with lemon juice, salt and pepper.\n3. Spread on toast and sprinkle with red pepper flakes.", "Avocado Toast" },
                    { 3, "Dessert", 25, new DateTime(2025, 5, 15, 22, 30, 34, 987, DateTimeKind.Local).AddTicks(2427), "Classic homemade cookies that are crisp on the outside and chewy in the middle.", 0, "/images/cookies.jpg", "250g flour, 1/2 tsp baking soda, 170g melted butter, 100g white sugar, 200g brown sugar, 1 tsp vanilla, 1 egg, 1 egg yolk, 200g chocolate chips", "1. Mix dry ingredients.\n2. Cream butter and sugars, add eggs and vanilla.\n3. Combine with dry ingredients and fold in chocolate chips.\n4. Bake at 325°F for 15 minutes.", "Chocolate Chip Cookies" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
