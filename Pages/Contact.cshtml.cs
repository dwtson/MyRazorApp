using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; } = string.Empty;

        [BindProperty]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        public string Department { get; set; } = "Admissions";

        [BindProperty]
        public string Message { get; set; } = string.Empty;

        public string? ConfirmationMessage { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(FullName) && !string.IsNullOrWhiteSpace(Email))
            {
                ConfirmationMessage = $"Thank you, {FullName}. Your message to {Department} has been received and we will reply to {Email} shortly.";
            }
        }
    }
}
