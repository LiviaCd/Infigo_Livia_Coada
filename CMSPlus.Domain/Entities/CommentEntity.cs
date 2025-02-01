using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Entities
{
    public class CommentEntity : BaseEntity
    {
        public string FullName { get; set; } = null!;
     //   [Required]
        public string Comment { get; set; } = null!;
       // [Required]
        public int TopicId { get; set; }
        public TopicEntity Topic { get; set; }
    }
}
