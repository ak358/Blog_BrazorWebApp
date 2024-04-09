using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_BrazorWebApp.Model
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false)]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string? Password { get; set; }

    }
}
