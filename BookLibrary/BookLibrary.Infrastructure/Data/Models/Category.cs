using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Id = Guid.NewGuid().ToString();
            this.BookCategories = new HashSet<BookCategory>();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }

    }
}
