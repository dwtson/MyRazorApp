using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Data;
using MyRazorApp.Models;

namespace MyRazorApp.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly KasperDbContext _context;

        public CreateModel(KasperDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Course Course { get; set; } = new Course();

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Courses.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
