using AutoMapper;
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
        private readonly IMapper mapper;

        public CoursesController(ICmsRepository cmsRepository, IMapper mapper)
        {
            this._cmsRepository = cmsRepository;
            this.mapper = mapper;
        }

        //Approach 1
        //[HttpGet]
        //public IEnumerable<Course> GetCourses()
        //{
        //    return _cmsRepository.GetAllCourses();
        //}

        // Return type - Approach 1 - primitive or complex type
        //[HttpGet]
        //public IEnumerable<CourseDto> GetCourses()
        //{
        //    try
        //    {
        //        IEnumerable<Course> courses = _cmsRepository.GetAllCourses();
        //        var result = MapCourseToCourseDto(courses);
        //        return result;
        //    }
        //    catch (System.Exception)
        //    {

        //        throw;
        //    }
        //}

        // Return type - Approach 2 - IActionResult
        //[HttpGet]
        //public IActionResult GetCourses()
        //{
        //    try
        //    {
        //        IEnumerable<Course> courses = _cmsRepository.GetAllCourses();
        //        var result = MapCourseToCourseDto(courses);
        //        return Ok(result);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}


        // Return type - Approach 3 - ActionResult<T>
        //[HttpGet]
        //public ActionResult<IEnumerable<CourseDto>> GetCourses()
        //{
        //    try
        //    {
        //        IEnumerable<Course> courses = _cmsRepository.GetAllCourses();
        //        var result = MapCourseToCourseDto(courses);
        //        return result.ToList(); // Convert to support ActionResult<T>
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}

        // Return type - Approach 3 - ActionResult<T>
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CourseDto>>> GetCoursesAsync()
        //{
        //    try
        //    {
        //        IEnumerable<Course> courses = await _cmsRepository.GetAllCoursesAsync();
        //        //var result = MapCourseToCourseDto(courses);
        //        var result = mapper.Map<CourseDto[]>(courses);
        //        return result.ToList(); // Convert to support ActionResult<T>
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}


        #region Custom mapper function
        // Custom mapper functions

        //private CourseDto MapCourseToCourseDto(Course course)
        //{
        //    return new CourseDto()
        //    {
        //        CourseId = course.CourseId,
        //        CourseName = course.CourseName,
        //        CourseDuration = course.CourseDuration,
        //        CourseType = (Cms.WebApi.DTOs.COURSE_TYPE)course.CourseType
        //    };
        //}

        //private IEnumerable<CourseDto> MapCourseToCourseDto(IEnumerable<Course> courses)
        //{
        //    IEnumerable<CourseDto> result;

        //    result = courses.Select(c => new CourseDto()
        //    {
        //        CourseId = c.CourseId,
        //        CourseName = c.CourseName,
        //        CourseDuration = c.CourseDuration,
        //        CourseType = (Cms.WebApi.DTOs.COURSE_TYPE)c.CourseType
        //    });

        //    return result;
        //}
        #endregion

    }
}
