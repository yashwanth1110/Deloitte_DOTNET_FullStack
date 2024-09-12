using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;
using WebApplication7.Services;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        public IStudentService _service;
        public StudentApiController(IStudentService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_service.GetAllStudents());
        }


        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student obj = _service.GetStudentById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested Student details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }


        [HttpPost]
        public IActionResult CreateStudent(Student obj)
        {
            _service.AddStudent(obj);
            return Ok(new { result = "Student Details added to db" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student obj = _service.GetStudentById(id);
            if (obj == null)
            {
                return NotFound(new { result = "Requested student details are not available." });
            }
            else
            {
                _service.DeleteStudent(id);
                return Ok(new { result = "Student Details deleted sucessfully" });
            }
            
        }

        [HttpPut]
        public IActionResult UpdateStudent(Student obj)
        {
            

            if (obj == null)
            {
                return NotFound(new { result = "Requested student details are not available." });
            }
            else
            {
                _service.UpdateStudent(obj);
                return Ok(new { result = "Student Details updated sucessfully" });
            }
            
        }
    }
}
