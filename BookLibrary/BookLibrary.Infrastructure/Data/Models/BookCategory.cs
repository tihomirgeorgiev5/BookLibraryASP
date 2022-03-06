using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class BookCategory
    {
        [MaxLength(IdMaxLength)]
        public string BookId { get; set; }

        [ForeignKey(nameof(Book))]
        public Book Book { get; set; }



        [MaxLength(IdMaxLength)]
        public string CategoryId { get; set; }

        [ForeignKey(nameof(Category))]
        public Category Category { get; set; }
    }
}
