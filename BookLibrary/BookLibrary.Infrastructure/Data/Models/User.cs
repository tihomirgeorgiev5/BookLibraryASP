using System.ComponentModel.DataAnnotations;
using static BookLibrary.Infrastructure.Data.DataConstants;


namespace BookLibrary.Infrastructure.Data.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; }

        [Required]
        [Range(UserMinName,UserMaxName)]
        public string FirstName { get; set; }

        [Required]
        [Range(UserMinName,UserMaxName)]
        public string LastName { get; set; }

        [Required]
        
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
