using crud_web_api_repository_pattern.Dto;
using crud_web_api_repository_pattern.Models;

namespace crud_web_api_repository_pattern.Factories;

public interface IStudentFactory
{
    StudentDto MapStudentEntityToDto(Student entity);
}
