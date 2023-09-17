using Cms.WebApi.Cms.Data.Repository.Models;
using CmsWebApi.Cms.Data.Repository.Models;

namespace Cms.WebApi.Cms.Data.Repository.Repositories
{
    public interface ICmsRepository
    {

        //Collection
        IEnumerable<Course> GetAllCourses();

        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Course AddCourse(Course newCourse);

        bool IsCourseExists(int courseId);

        // Individual item

        Course GetCourse(int courseId);

        Course UpdateCourse(int courseId, Course newCourse);

        Course DeleteCourse(int courseId);

        // Association

        IEnumerable<Student> GetStudents(int courseId);

        Student AddStudent(Student student);

    }
}
