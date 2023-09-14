using Cms.WebApi.Cms.Data.Repository.Models;
using Cms.WebApi.Cms.Data.Repository.Repositories;
using Cms.WebApi.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CmsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICmsRepository _cmsRepository;
        public CoursesController(ICmsRepository cmsRepository)
        {
            this._cmsRepository = cmsRepository;
        }

        //Approach 1
        //[HttpGet]
        //public IEnumerable<Course> GetCourses()
        //{
        //    return _cmsRepository.GetAllCourses();
        //}

        // Return type - Approach 1 - primitive or complex type
        [HttpGet]
        public IEnumerable<CourseDto> GetCourses()
        {
            try
            {
                IEnumerable<Course> courses = _cmsRepository.GetAllCourses();
                var result = MapCourseToCourseDto(courses);
                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        

        // Custom mapper functions

        private IEnumerable<CourseDto> MapCourseToCourseDto(IEnumerable<Course> courses)
        {
            IEnumerable<CourseDto> result;

            result = courses.Select(c => new CourseDto()
            {
                CourseId = c.CourseId,
                CourseName = c.CourseName,
                CourseDuration = c.CourseDuration,
                CourseType = (Cms.WebApi.DTOs.COURSE_TYPE)c.CourseType
            });

            return result;
        }
    }
}
