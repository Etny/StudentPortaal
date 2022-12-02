
using System.ComponentModel.DataAnnotations;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.API.Models
{
    public record AddCommentRequest
    {
        [Required]
        public int AssignmentId { get; set; } = 0;
        [Required]
        public string Content { get; set; } = String.Empty;
    }
}