using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_BrazorWebApp.Model
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Title { get; set; } = "";

        [Column(TypeName = "nvarchar(255)")]
        public string ContentHeader { get; set; } = "";

        public DateTime Data { get; set; }
    }
}
