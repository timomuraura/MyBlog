using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyNiceBlog.Models
{
    public class Author
    {
        [Column("AuthorId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int AuthorId { get; set; }

        [Column("AuthorName")]
        [Required]
        [StringLength(50)]
        public string AuthorName { get; set; }

        [Column("DateOfBirth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        
    }
}
