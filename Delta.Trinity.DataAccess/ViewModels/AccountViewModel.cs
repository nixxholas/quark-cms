using System.ComponentModel.DataAnnotations;

namespace Delta.Trinity.DataAccess.ViewModels
{
    public class AccountViewModel
    {
        [Key]
        public int Id { get; protected set; }

        [Required(ErrorMessage = "Username is required")]
        [MinLength(5)]
        [MaxLength(50)]
        public string Username { get; protected set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string ShaPassHash { get; protected set; }

        [EmailAddress]
        public string Email { get; protected set; }
    }
}