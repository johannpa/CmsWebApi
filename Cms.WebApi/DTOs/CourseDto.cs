using Cms.WebApi.Cms.Data.Repository.Models;
using System.Text.Json.Serialization;

namespace Cms.WebApi.DTOs
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public COURSE_TYPE CourseType { get; set; }
        
    }

    public enum COURSE_TYPE
    {
        ENGINEERING,
        MEDICAL,
        MANAGEMENT
    }
}
