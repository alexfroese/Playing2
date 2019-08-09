using System.ComponentModel.DataAnnotations;

namespace Playing2.Models
{
    public partial class Author : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Website { get; set; }
    }
}