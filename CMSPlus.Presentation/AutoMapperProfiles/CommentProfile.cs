using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModel;
using CMSPlus.Domain.Models.TopicModels;

namespace CMSPlus.Presentation.AutoMapperProfiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentCreateModel, CommentEntity>();
        }
    }
}
