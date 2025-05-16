using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeShare.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Instructions { get; set; }

        [Display(Name = "Cooking Time (minutes)")]
        [Range(1, 1000)]
        public int CookingTimeMinutes { get; set; }

        [Display(Name = "Difficulty Level")]
        public DifficultyLevel Difficulty { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string Category { get; set; }
    }

    public enum DifficultyLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }
}