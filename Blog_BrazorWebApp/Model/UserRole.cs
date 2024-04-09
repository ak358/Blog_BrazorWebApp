using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_BrazorWebApp.Model
{
    public class UserRole
    {
        public int Id { get; set; }
        public string? RoleName { get; set; }
    }
}
