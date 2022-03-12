using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;


namespace BookLibrary.Infrastructure.Data.Models
{
    public class User
    {
        public User()
        {
            
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public int Id { get; init; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Username { get; set; }

        public int Age { get; set; }


        [Required] 
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsReturn { get; set; }
    }
}
