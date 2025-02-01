using CMSPlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models.CommentModel
{
    public class CommentCreateModel : BaseCommentModel 
    {
        public string FullName { get; set; }
        public string Comment { get; set; } 
        public int TopicId { get; set; }
        public TopicEntity Topic { get; set; }
    }
}
