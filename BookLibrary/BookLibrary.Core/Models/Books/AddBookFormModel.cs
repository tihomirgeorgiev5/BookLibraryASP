using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Core.Models.Books
{
    
    
    public class AddBookFormModel
    {
        [Required]
        [StringLength(BookTitleMaxLength, MinimumLength = BookTitleMinLength)] 
        public string Title { get; init; }

        [Required]
        [StringLength(BookAuthorMaxLength, MinimumLength =BookAuthorMinLength)]
        public string Author { get; init; }

        [Display(Name = "Image URL")]
        [Url]
        [Required]
        public string ImageUrl { get; init; }

        [Required]
        [StringLength(
            int.MaxValue,
            MinimumLength = BookDescriptionMinLength,
            ErrorMessage = "The field Description must be a string with a minimum length of {2}")]
        public string Description { get; init; }

        [Range(BookYearMinValue, BookYearMaxValue)]
        public int Year { get; init; }

        [Display(Name = "Category")]
        public int CategoryId { get; init; }

        public IEnumerable<BookCategoryViewModel> Categories { get; set; }

    }
    
}
