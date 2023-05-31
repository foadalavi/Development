using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using School.Ui.Services;

namespace School.Ui.Pages.Student
{
    public class DeleteModel : PageModel
    {
        private readonly ISchoolService _service;

        public DeleteModel(ISchoolService service)
        {
            _service = service;
        }
        public async Task<IActionResult> OnPost(int id)
        {
            await _service.DeleteStudentAsync(id);
            return RedirectToPage("/Student/index");
        }
    }
}
