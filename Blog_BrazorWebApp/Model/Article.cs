using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_BrazorWebApp.Model
{
    public class Article
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "タイトルを入力してください。")]
        [Column(TypeName = "nvarchar(255)")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "コンテンツを入力してください。")]
        [Column(TypeName = "nvarchar(max)")]
        public string Content { get; set; } = "";

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;

        [ForeignKey("UserAccount")]
        public int UserId { get; set; }

        public UserAccount? UserAccount { get; set; }
    }
}
