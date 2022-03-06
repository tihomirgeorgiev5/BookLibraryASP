using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Language
    {
        public Language()
        {
            this.LanguageId = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string LanguageId { get; init; }

        [Required]
        [MaxLength(LanguageCodeMaxLength)]
        public string LanguageCode { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string LanguageName { get; set; }
    }
}
