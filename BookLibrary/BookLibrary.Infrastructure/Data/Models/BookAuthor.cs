namespace BookLibrary.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class BookAuthor
    {
        [ForeignKey(nameof(Book))]
        public string BookId { get; set; }
        public Book Book { get; set; }


        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
