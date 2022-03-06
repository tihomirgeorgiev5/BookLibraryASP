using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;


namespace BookLibrary.Infrastructure.Data.Models
{
    public class User
    {
        public User()
        {
            this.UserId = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string UserId { get; init; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Username { get; set; }
 

        [Required]
        
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
