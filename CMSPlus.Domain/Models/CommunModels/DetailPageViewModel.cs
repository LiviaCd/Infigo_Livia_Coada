using CMSPlus.Domain.Models.CommentModel;
using CMSPlus.Domain.Models.TopicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models.CommunModels
{
    public class DetailPageViewModel
    {
        public TopicDetailsModel TopicDetails { get; set; }
        public CommentCreateModel NewComment { get; set; } 
        //public string FullName { get; set; }
        //public string Comment { get; set; }
        //public int TopicId { get; set; }
    }
}
