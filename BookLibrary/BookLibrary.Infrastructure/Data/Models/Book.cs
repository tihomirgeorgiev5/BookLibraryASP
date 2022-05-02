using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Book
    {

        public int Id { get; init; }

        [Required]
        [MaxLength(BookTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(BookAuthorMaxLength)]
        public string Author { get; set; }

        [Required]
        [MaxLength(BookPublisherMaxLength)]
        public string Publisher { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        public int Pages { get; set; }

        public int Year { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; init; }

    }
}

