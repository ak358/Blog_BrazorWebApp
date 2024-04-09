using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_BrazorWebApp.Model
{
    public class UserAccount
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? UserName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters")]
        public string? Password { get; set; }

        [ForeignKey("UserRole")]
        public int RoleId { get; set; }

        public UserRole? UserRole { get; set; }
    }
}
