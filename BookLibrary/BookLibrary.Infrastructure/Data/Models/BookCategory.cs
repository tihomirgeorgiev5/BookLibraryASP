using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
