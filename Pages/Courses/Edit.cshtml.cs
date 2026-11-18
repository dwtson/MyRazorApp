using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;
using MyRazorApp.Models;

namespace MyRazorApp.Pages.Courses
{
    public class EditModel : PageModel
    {
        private readonly KasperDbContext _context;

        public EditModel(KasperDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            Course = course;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Courses.Any(e => e.Id == Course.Id))
                {
                    return NotFound();
                }
                throw;
            }

            return RedirectToPage("./Index");
        }
    }
}
