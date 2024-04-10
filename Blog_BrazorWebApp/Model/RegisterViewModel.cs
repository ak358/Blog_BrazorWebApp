using System.ComponentModel.DataAnnotations;

namespace Blog_BrazorWebApp.Model
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string UserName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
