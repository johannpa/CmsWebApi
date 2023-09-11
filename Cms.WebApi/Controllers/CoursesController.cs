using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        public CoursesController()
        {
            
        }

        [HttpGet]
        public IEnumerable<CoursesController> GetCourses()
        {
            //return "Hello, World!";
        }
    }
}
