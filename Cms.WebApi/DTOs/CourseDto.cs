using Cms.WebApi.Cms.Data.Repository.Models;

namespace Cms.WebApi.DTOs
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        public COURSE_TYPE CourseType { get; set; }
        
    }

    public enum COURSE_TYPE
    {
        ENGINEERING,
        MEDICAL,
        MANAGEMENT
    }
}
