namespace Cms.WebApi.Cms.Data.Repository.Models
{
    public class Course
    {
        public int Id { get; set; }
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
