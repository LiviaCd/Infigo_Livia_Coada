using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _repository;

        public CommentService(ICommentRepository repository)
        {
            _repository = repository;
        }
        public async Task Create(CommentEntity entity)
        {
            //TopicEntity topic = new TopicEntity
            //{
            //    Id = 2,
            //    Title = "123",
            //    Body = "123",
            //    SystemName = "321"
            //};
            //entity.Topic = topic;
            await _repository.Create(entity);
        }
    }
}
