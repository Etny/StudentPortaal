using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.Business.Services
{
    public class TagService : ITagService
    {
        private readonly IRepository<Tag> repository;

        public TagService(IRepository<Tag> repository)
        {
            this.repository = repository;
        }

        public async Task<Tag> CreateTagAsync(Tag tag)
        {
            Tag createdTag = await repository.CreateAsync(tag);
            await repository.SaveChangesAsync();
            return createdTag;
        }

        public Tag? GetById(int tagId)
        {
            return repository.GetById(tagId);
        }

        public List<Tag> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task DeleteById(int id)
        {
            repository.DeleteById(id);
            await repository.SaveChangesAsync();
        }
    }
}
