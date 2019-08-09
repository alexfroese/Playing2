using System.ComponentModel.DataAnnotations;

namespace Playing2.Models
{
    public partial class PostType : BaseEntity
    {
        public static readonly PostType Personal = new PostType { ID = 1, Name = "Personal" };
        public static readonly PostType Public = new PostType { ID = 2, Name = "Public" };
        public static readonly PostType Other = new PostType { ID = 3, Name = "Other" };

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}