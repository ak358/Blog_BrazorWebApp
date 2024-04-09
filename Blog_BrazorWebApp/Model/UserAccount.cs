using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Blog_BrazorWebApp.Model
{
    public class UserAccount
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        [ForeignKey("UserRole")]
        public int RoleId { get; set; }

        public UserRole? UserRole { get; set; }

    }
}
