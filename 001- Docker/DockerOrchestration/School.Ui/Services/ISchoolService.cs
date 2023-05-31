using School.Domain.Models;

namespace School.Ui.Services
{
    public interface ISchoolService
    {
        Task<string> AddStudentAsync(Student student);
        Task<string> DeleteStudentAsync(int id);
        Task<Student> GetStudentAsync(int id);
        Task<List<Student>> GetStudentsAsync();
        Task<string> UpdateStudentAsync(Student student);
    }
}