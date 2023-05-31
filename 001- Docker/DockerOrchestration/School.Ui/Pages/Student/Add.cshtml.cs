using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using School.Ui.Services;

namespace School.Ui.Pages.Student
{
    public class AddModel : PageModel
    {
        private readonly ISchoolService _service;

        [BindProperty]
        public Domain.Models.Student Student { get; set; }

        public AddModel(ISchoolService service)
        {
            _service = service;
        }

        public async Task OnGet()
        {
            this.Student = new();
            this.Student.BirthDay = DateTime.Now;
        }
        public async Task<IActionResult> OnPost()
        {
            await _service.AddStudentAsync(Student);
            return RedirectToPage("/Student/index");
        }
    }
}
