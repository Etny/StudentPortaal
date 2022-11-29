using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "Teacher, Admin")]
        [HttpPost("create")]
        public async Task<IActionResult> CreateAssignment([FromBody] Assignment assignment)
        {
            Assignment createdAssignment = await assignmentService.CreateAssignment(assignment);
            return Ok(createdAssignment);
        }

        [Authorize(Roles = "Student, Teacher, Admin")]
        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            Assignment? assignment = assignmentService.GetById(id);

            return assignment == null ? NotFound() : Ok(assignment);
        }
    }
}
