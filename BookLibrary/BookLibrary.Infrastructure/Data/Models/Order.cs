using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;

namespace BookLibrary.Infrastructure.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        public DateTime? BookGetTime { get; set; }
        public DateTime? BookTakeTime { get; set; }

        [Required]
        [MaxLength(IdMaxLength)]
        public string UserId { get; init; }



    }
}
