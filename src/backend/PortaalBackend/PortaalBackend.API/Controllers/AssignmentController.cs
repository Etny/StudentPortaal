using Mapster;
using MapsterMapper;
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
        private readonly IMapper _mapper;

        public AssignmentController(IAssignmentService assignmentService, IMapper mapper)
        {
            this.assignmentService = assignmentService;
            _mapper = mapper;
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
            Assignment converted = _mapper.Map<Assignment>(assignment);
            Assignment createdAssignment = await assignmentService.CreateAssignmentAsync(converted);
            return Ok(createdAssignment);
        }

        [HttpPost("comment")]
        public async Task<IActionResult> AddComment([FromBody] AddCommentRequest request)
        {
            Comment converted = _mapper.Map<Comment>(request);
            Comment comment = await assignmentService.AddCommentAsync(converted);
            return Ok(comment);
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
