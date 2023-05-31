using School.Domain.Helper;
using School.Domain.Models;

namespace School.Ui.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly HttpClient _httpClient;


        public SchoolService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            var response = await _httpClient.GetAsync(Endpoints.GetAllStudents);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<List<Student>>();
            return result;
        }

        public async Task<Student> GetStudentAsync(int id)
        {
            var url = $"{Endpoints.GetStudent}/{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<Student>();
            return result;
        }

        public async Task<string> AddStudentAsync(Student student)
        {
            var response = await _httpClient.PostAsync(Endpoints.AddStudent, HttpHelper.GetHttpContect(student));
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> UpdateStudentAsync(Student student)
        {
            var response = await _httpClient.PutAsync(Endpoints.UpdateStudent, HttpHelper.GetHttpContect(student));
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> DeleteStudentAsync(int id)
        {
            var url = $"{Endpoints.DeleteStudents}?Id={id}";
            var response = await _httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
