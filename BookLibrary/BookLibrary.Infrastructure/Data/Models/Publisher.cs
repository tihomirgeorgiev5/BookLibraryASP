using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Publisher
    {
        public Publisher()
        {
            this.PublisherId = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string PublisherId { get; init; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string PublisherName { get; set; }
    }

}
