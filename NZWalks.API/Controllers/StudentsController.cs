using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // URI: https://localhost:portnumber/api/sudents
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentsNames = new string[] { "Maria", "Jane", "Emily" };

            return Ok(studentsNames);
            //code 200 = Ok
        }
    }
}
