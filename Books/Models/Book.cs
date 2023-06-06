using System;
using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
	public class Book
	{
        public Guid ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Name { get; set; } = default!;
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Author { get; set; } = default!;
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int PagesNumber { get; set; }
        [StringLength(600, MinimumLength = 5)]
        [Required]
        public string Description { get; set; } = default!;
    }
}

