using Cms.WebApi.Cms.Data.Repository.Models;

namespace Cms.WebApi.Cms.Data.Repository.Repositories
{
    public interface ICmsRepository
    {
        IEnumerable<Course> GetAllCourses();

        Task<IEnumerable<Course>> GetAllCoursesAsync();

    }
}
