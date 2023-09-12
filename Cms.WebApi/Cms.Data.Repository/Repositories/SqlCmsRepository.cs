using Cms.WebApi.Cms.Data.Repository.Models;

namespace Cms.WebApi.Cms.Data.Repository.Repositories
{
    public class SqlCmsRepository: ICmsRepository
    {
        public SqlCmsRepository()
        {
            
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return null;
        }
    }
}
