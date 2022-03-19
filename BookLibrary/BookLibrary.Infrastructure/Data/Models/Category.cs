using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Category
    {
        public Category()
        {
           
            this.Books = new List<Book>();
        }

        public int Id { get; init; }

        [Required]
        
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; init; }

    }
}
