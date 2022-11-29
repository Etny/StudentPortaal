using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortaalBackend.API.Models;
using PortaalBackend.Business.Extensions;
using PortaalBackend.Business.Extensions.Models;
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

        [HttpGet("all")]
        public IActionResult GetAll([FromQuery] AssignmentFilterOptions options)
        {
            List<Assignment> assignments = assignmentService.GetAll();
            assignments = assignments.FilterAndSort(options);

            return Ok(assignments);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAssignment([FromBody] CreateAssignmentInput assignment)
        {
            Assignment createdAssignment = await assignmentService.CreateAssignmentAsync(assignment.ToAssignment());
            return Ok(createdAssignment);
        }

        // [Authorize(Roles = "Student, Teacher, Admin")]
        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            Assignment? assignment = assignmentService.GetById(id);

            return assignment == null ? NotFound() : Ok(assignment);
        }
    }
}
