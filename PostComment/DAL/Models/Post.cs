using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [ForeignKey("User")]
        public string PostedBy { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }  
        public virtual ICollection<Comment> Comments { get; set; }
        public Post() {
            Comments = new List<Comment>();
        }
    }
}
