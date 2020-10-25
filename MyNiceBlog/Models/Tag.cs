using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyNiceBlog.Models
{
    public class Tag
    {
        [Column("TagId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int TagId { get; set; }

        [Column("TagName ")]
        [Required]
        [StringLength(50)]
        public string TagName { get; set; }

        public IList<PostTag> PostTags { get; set; }
    }
}
