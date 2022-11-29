
using System.ComponentModel.DataAnnotations;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.API.Models
{
    public record CreateAssignmentInput
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        // public List<string> Tags = new(); 

        public Assignment ToAssignment()
        {
            return new()
            {
                Title = this.Title,
                Description = this.Description
            };
        }
    }
}