﻿using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
            this.AuthorId = Guid.NewGuid().ToString();
            
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string AuthorId { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }


    }
}
