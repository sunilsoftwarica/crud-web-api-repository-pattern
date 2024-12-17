using crud_web_api_repository_pattern.Models;
using crud_web_api_repository_pattern.Repositories.GenericRepository;

namespace crud_web_api_repository_pattern.Repositories.StudentRepo
{
    public interface IStudentRepository : IRepository<Student>
    {
    }
}
