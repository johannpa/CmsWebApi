using Cms.WebApi.Cms.Data.Repository.Models;
using Cms.WebApi.Cms.Data.Repository.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICmsRepository _cmsRepository;
        public CoursesController(ICmsRepository cmsRepository)
        {
            
        }

        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return _cmsRepository.GetAllCourses();
        }
    }
}
