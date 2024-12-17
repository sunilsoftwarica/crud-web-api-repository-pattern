using crud_web_api_repository_pattern.Models;
using crud_web_api_repository_pattern.Repositories.StudentRepo;

namespace crud_web_api_repository_pattern.Services
{
    public class StudentService : IStudentService
    {
        #region Ctor & Properties

        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository stundentRepository)
        {
            _studentRepository = stundentRepository;
        }

        #endregion

        #region Method

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var data = await _studentRepository.GetByIdAsync(id).ConfigureAwait(false);
            return data;
        }

        #endregion
    }
}
