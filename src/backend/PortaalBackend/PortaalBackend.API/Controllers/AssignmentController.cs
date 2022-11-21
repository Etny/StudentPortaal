using Microsoft.AspNetCore.Mvc;
using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            this.assignmentService = assignmentService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAssignment([FromBody] Assignment assignment)
        {
            Assignment createdAssignment = await assignmentService.CreateAssignment(assignment);
            return Ok(createdAssignment);
        }
    }
}
