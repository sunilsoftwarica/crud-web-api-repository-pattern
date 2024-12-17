using crud_web_api_repository_pattern.Dto;
using crud_web_api_repository_pattern.Models;

namespace crud_web_api_repository_pattern.Factories;

public class StudentFactory : IStudentFactory
{
    public StudentDto MapStudentEntityToDto(Student entity)
    {
        StudentDto dto = new();
        {
            dto.FirstName = entity.FirstName;
            dto.Email = entity.Email;
            dto.Address = entity.Address;
        }
        return dto;
    }
}
