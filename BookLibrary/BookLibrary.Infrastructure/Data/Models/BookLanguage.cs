using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class BookLanguage
    {
        public BookLanguage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [MaxLength(LanguageCodeMaxLength)]
        public string LanguageCode { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string LanguageName { get; set; }

        [Required]
        [ForeignKey(nameof(Book))]
        public string BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
