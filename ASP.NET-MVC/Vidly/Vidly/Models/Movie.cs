using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleasedDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}