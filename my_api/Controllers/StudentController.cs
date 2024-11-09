using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace my_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<dynamic> students_list = new List<dynamic>()
        {
            new{ Id=1, Name="Amar", Email="amar@gmail.com", City="Mumbai"},
            new{ Id=2, Name="Nisha", Email="nisha@gmail.com", City="Pune"},
            new{ Id=3, Name="Sadashiv", Email="sadashiv@gmail.com", City="Sangli"}
        };

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            try
            {
                return Ok(students_list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
