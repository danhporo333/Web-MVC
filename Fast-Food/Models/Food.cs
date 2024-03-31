using System.ComponentModel.DataAnnotations;

namespace Fast_Food.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [Display(Name = "Release Date")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Category { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public float? Rating { get; set; }
        public string? Image { get; set; }
        public int Quantity { get; internal set; }
    }
}
