using School.Domain.Models;

namespace School.Api.Services
{
    public interface IStudentService
    {
        Task<bool> AddStudentAsync(Student newStudent);
        Task<bool> DeleteStudentAsync(int Id);
        Task<bool> EditStudentAsync(Student editedStudent);
        Task<Student> GetStudentAsync(int Id);
        Task<List<Student>> GetStudentsAsync();
    }
}