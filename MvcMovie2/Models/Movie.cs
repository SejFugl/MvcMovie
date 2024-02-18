using System.ComponentModel.DataAnnotations;

namespace MvcMovie2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [StringLength(50)]
        public string Genre { get; set; }
        public decimal Price { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayFormat(NullDisplayText = "No title")]
        public string Title { get; set; }
    }
}
