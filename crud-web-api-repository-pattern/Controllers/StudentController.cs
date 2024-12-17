
using crud_web_api_repository_pattern.Dto;
using crud_web_api_repository_pattern.Factories;
using crud_web_api_repository_pattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace crud_web_api_repository_pattern.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Ctor & Properties

        private readonly IStudentService _studentService;
        private readonly IStudentFactory _studentFactory;
        public StudentController(IStudentService studentService, IStudentFactory studentFactory)
        {
            _studentService = studentService;
            _studentFactory = studentFactory;
        }

        #endregion


        #region

        [Route("student/{id}")]
        [HttpGet]
        public async Task<ActionResult<StudentDto>> GetStudentById(int id)
        {
            var response = await _studentService.GetStudentByIdAsync(id).ConfigureAwait(false);
            if (response == null)
                return NotFound();
            var mappedData = _studentFactory.MapStudentEntityToDto(response);
            return Ok(mappedData);
        }

        #endregion
    }
}
