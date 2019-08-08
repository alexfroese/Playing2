using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Playing2.Models
{
    public class Blog : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public List<Post> Posts { get; set; }
    }
}