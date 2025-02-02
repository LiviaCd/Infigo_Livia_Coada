using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Persistance;
using Microsoft.EntityFrameworkCore;

namespace CMSPlus.Domain.Repositories;

public class TopicRepository:Repository<TopicEntity>,ITopicRepository
{
    public TopicRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<TopicEntity?> GetBySystemName(string systemName)
    {
        return await _dbSet
            .Where(topic => topic.SystemName == systemName)
            .Include(topic => topic.Comments)
            .SingleOrDefaultAsync();
    }
}