using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyNiceBlog.Models
{
    public class Post
    {
        [Column("PostId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int PostId { get; set; }

        [Column("Title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column("PostText")]
        [Required]
        [StringLength(500)]
        public string PostText { get; set; }

        [Column("DatePublished ")]
        [Required]
        public DateTime DatePublished { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        public IList<PostTag> PostTags { get; set; }

    }
}
