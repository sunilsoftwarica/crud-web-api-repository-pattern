using crud_web_api_repository_pattern.Data;
using crud_web_api_repository_pattern.Models;
using crud_web_api_repository_pattern.Repositories.GenericRepository;

namespace crud_web_api_repository_pattern.Repositories.StudentRepo
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
