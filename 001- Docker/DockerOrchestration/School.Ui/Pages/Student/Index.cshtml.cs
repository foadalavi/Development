using Microsoft.AspNetCore.Mvc.RazorPages;
using School.Ui.Services;

namespace School.Ui.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly ISchoolService _service;

        public List<Domain.Models.Student> Students { get; set; }

        public IndexModel(ISchoolService service)
        {
            _service = service;
        }

        public async Task OnGet()
        {
            this.Students = await _service.GetStudentsAsync();
        }
    }
}
