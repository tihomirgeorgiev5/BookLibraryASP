using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Data.Models
{
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
