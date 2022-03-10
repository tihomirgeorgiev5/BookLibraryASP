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
            this.Id = Guid.NewGuid().ToString();
            this.BookCategories = new HashSet<BookCategory>();
            this.BookAuthors = new HashSet<BookAuthor>();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

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
        [ForeignKey(nameof(Publisher))]
        public string PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }


        [Required]
        [ForeignKey(nameof(Order))]
        public string OrderId { get; set; }
        public virtual Order Order { get; set; }


        public ICollection<BookCategory> BookCategories { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }



    }
}

