using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;
using MyRazorApp.Models;

namespace MyRazorApp.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly KasperDbContext _context;

        public IndexModel(KasperDbContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; } = new List<Course>();
        public string CoursesJson { get; set; } = "[]";

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .OrderBy(c => c.CourseSubject)
                .ThenBy(c => c.CourseTitle)
                .ToListAsync();

            CoursesJson = JsonSerializer.Serialize(Courses);
        }
    }
}
