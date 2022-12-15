using Microsoft.AspNetCore.Mvc;
using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService tagService;

        public TagController(ITagService tagService)
        {
            this.tagService = tagService;
        }

        [HttpGet("all")]
        public IActionResult GetAll(string searchQuery = "")
        {
            List<Tag> tags = string.IsNullOrEmpty(searchQuery) ? 
                tagService.GetAll() : 
                tagService.GetAll().Where(x => x.Name.ToLower().Contains(searchQuery.ToLower())).ToList();

            return Ok(tags);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAssignment([FromBody] string tagName)
        {
            Tag newTag = new() { Name = tagName };
            Tag createdTag = await tagService.CreateTagAsync(newTag);
            return Ok(createdTag);
        }

        // [Authorize(Roles = "Student, Teacher, Admin")]
        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            Tag? tag = tagService.GetById(id);

            return tag == null ? NotFound() : Ok(tag);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await tagService.DeleteById(id);

            return Ok();
        }
    }
}
