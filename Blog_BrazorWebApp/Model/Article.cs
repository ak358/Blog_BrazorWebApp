using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_BrazorWebApp.Model
{
    public class Article
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Title { get; set; } = "";

        [Column(TypeName = "nvarchar(max)")]
        public string Content { get; set; } = "";

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

    }
}
