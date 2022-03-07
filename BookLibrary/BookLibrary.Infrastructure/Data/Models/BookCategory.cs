using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class BookCategory
    {
        [ForeignKey(nameof(Book))]
        public string BookId { get; set; } 
        public Book Book { get; set; }


        [ForeignKey(nameof(Category))]
        public string CategoryId { get; set; }   
        public Category Category { get; set; }
    }
}
