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
        public string? FullName { get; set; } = string.Empty;
        public string? Comment { get; set; } = string.Empty;
        public int TopicId { get; set; }
    }
}
