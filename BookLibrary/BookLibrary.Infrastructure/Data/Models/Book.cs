using BookLibrary.Infrastructure.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Book
    {
        public Book()
        {
            this.BookId = Guid.NewGuid().ToString();
            this.Categories = new HashSet<Category>();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string BookId { get; init; }

        [Required]
        [MaxLength(BookTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        [Range(BookDescriptionMinLength,BookDescriptionMaxLength)]
        public string Description { get; set; }

        public EditionType EditionType { get; set; }

  
        public int Copies { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        [Required]
        [MaxLength(IdMaxLength)]
        public string AuthorId { get; set; }

       
        public Author Author { get; set; }

        [Required]
        [MaxLength(IdMaxLength)]
        public string PublisherId { get; set; }

        [Required]
        [MaxLength(IdMaxLength)]
        public string LanguageId { get; set; }

        [Required]
        [MaxLength(IdMaxLength)]
        public string OrderId { get; set; }


        public ICollection<Category> Categories { get; set; }


    }
}

