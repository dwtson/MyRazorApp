using System.ComponentModel.DataAnnotations;

namespace MyRazorApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the course title.")]
        [Display(Name = "Course Title")]
        public string CourseTitle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a course type.")]
        [Display(Name = "Course Type")]
        public string CourseType { get; set; } = "Undergraduate";

        [Required(ErrorMessage = "Please enter a course summary.")]
        [Display(Name = "Course Summary")]
        public string CourseSummary { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the award name.")]
        [Display(Name = "Award")]
        public string CourseAwardName { get; set; } = string.Empty;

        [Display(Name = "UCAS Code")]
        public string? UcasCode { get; set; }

        [Display(Name = "UCAS Points")]
        public int? UcasPoints { get; set; }

        [Required]
        [Display(Name = "Year of Entry")]
        public string YearOfEntry { get; set; } = "2027/28";

        [Required]
        [Display(Name = "Mode of Attendance")]
        public string ModeOfAttendance { get; set; } = "Full-time";

        [Required]
        [Display(Name = "Study Length")]
        public string StudyLength { get; set; } = "3 / 4 Years";

        [Display(Name = "Has Foundation Year")]
        public bool HasFoundationYear { get; set; }

        [Required]
        [Display(Name = "Subject Area")]
        public string CourseSubject { get; set; } = "Computing";

        [Display(Name = "No Longer Recruiting")]
        public bool NoLongerRecruiting { get; set; }
    }
}
