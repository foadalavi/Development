using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using School.Ui.Services;

namespace School.Ui.Pages.Student
{
    public class EditModel : PageModel
    {
        private readonly ISchoolService _service;

        [BindProperty]
        public Domain.Models.Student Student { get; set; }

        public EditModel(ISchoolService service)
        {
            _service = service;
        }

        public async Task OnGet(int id)
        {
            this.Student=await _service.GetStudentAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            await _service.UpdateStudentAsync(Student);
            return RedirectToPage("/Student/index");
        }
    }
}
