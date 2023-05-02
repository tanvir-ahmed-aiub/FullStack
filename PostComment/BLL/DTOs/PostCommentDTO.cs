using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PostCommentDTO : PostDTO
    {
        public List<CommentDTO> Comments { get; set; }
        public PostCommentDTO() { 
            Comments = new List<CommentDTO>();
        }
    }
}
