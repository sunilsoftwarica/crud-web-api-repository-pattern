using crud_web_api_repository_pattern.Models;

namespace crud_web_api_repository_pattern.Services
{
    public interface IStudentService
    {
        Task<Student> GetStudentByIdAsync(int id);
    }
}
