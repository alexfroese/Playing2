using System.ComponentModel.DataAnnotations;

namespace Playing2.Models
{
    public class Post : BaseEntity
    {
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public Author Author { get; set; }

        [Required]
        public Blog Blog { get; set; }

        [Required]
        public PostType PostType { get; set; }
    }
}