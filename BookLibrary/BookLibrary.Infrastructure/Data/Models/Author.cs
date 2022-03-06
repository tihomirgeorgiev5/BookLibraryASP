using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
