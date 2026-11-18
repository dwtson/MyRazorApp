using MyRazorApp.Models;

namespace MyRazorApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(KasperDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Courses.Any())
            {
                return;
            }

            var courses = new Course[]
            {
                new Course
                {
                    CourseTitle = "Computing",
                    CourseType = "Undergraduate",
                    CourseSummary = "Learn how to code, configure and integrate applications, databases and systems architectures which form the pillars of modern technology in today's world.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "G504",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Computer Networks",
                    CourseType = "Undergraduate",
                    CourseSummary = "This course includes general computing skills in programming, cyber security, information systems, management and professionalism in a technical environment.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "G420",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Cyber Security with Forensics",
                    CourseType = "Undergraduate",
                    CourseSummary = "Prepare for a career in cyber security by designing security systems, identifying evidence of cybercrimes and acting as detectives in a digital world.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "F4G4",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Computer Science for Games",
                    CourseType = "Undergraduate",
                    CourseSummary = "Create the software powering the next generation of blockbuster games.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "G611",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Software Engineering",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain experience in the whole software development process and prepare for a career in software engineering.",
                    CourseAwardName = "BEng (Honours)",
                    UcasCode = "G600",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Computer Science",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a solid foundation in the core areas of computer science, including programming, algorithms, data structures and software development.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "G400",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Computing with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in computing – with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "A020",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Cyber Security with Forensics with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in cyber security with forensics, with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "A023",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Software Engineering with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in software engineering, with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BEng (Honours)",
                    UcasCode = "A017",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Cyber Security with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in cyber security – with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "A093",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Information Technology with Business Studies with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in information technology with business studies, with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "A019",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Computer Science with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in computer science, with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "A022",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Computer Science for Games with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in computer science for games, with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "A092",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Business and Digital Technology with Foundation Year",
                    CourseType = "Undergraduate",
                    CourseSummary = "Gain a degree in business and digital communications technology – with an initial foundation year to prepare for the course.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "A018",
                    UcasPoints = 80,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "4/5 Years",
                    HasFoundationYear = true,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = true
                },
                new Course
                {
                    CourseTitle = "Computing",
                    CourseType = "Postgraduate",
                    CourseSummary = "A course enhanced by real-life project experience for non-computing graduates wanting to pursue a career in the IT industry.",
                    CourseAwardName = "MSc",
                    UcasCode = null,
                    UcasPoints = null,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Part-time",
                    StudyLength = "3 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Computing and Informatics",
                    CourseType = "Postgraduate",
                    CourseSummary = "Conduct a period of intensive, supervised study where you critically investigate and evaluate an approved topic and make an original contribution to knowledge.",
                    CourseAwardName = "MPhil",
                    UcasCode = null,
                    UcasPoints = null,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Part-time",
                    StudyLength = "3 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Cyber Security",
                    CourseType = "Postgraduate",
                    CourseSummary = "Develop your skills and academic knowledge in the growing field of cyber security through academic teaching, industry input and practical skills development. Currently applications for this course are only open to home students.",
                    CourseAwardName = "MSc",
                    UcasCode = null,
                    UcasPoints = null,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "1 Year",
                    HasFoundationYear = false,
                    CourseSubject = "Computing",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Graphic Design",
                    CourseType = "Undergraduate",
                    CourseSummary = "Develop your own creative and innovative approach to graphic design by challenging and exploring contemporary practices through a series of exciting and diverse projects.",
                    CourseAwardName = "BA (Honours)",
                    UcasCode = "W210",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Art and design",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Interior Architecture and Design",
                    CourseType = "Undergraduate",
                    CourseSummary = "Develop your own creative and sustainable approach to interior architecture and design by challenging and exploring contemporary practices through a series of exciting and diverse projects.",
                    CourseAwardName = "BA (Honours)",
                    UcasCode = "W250",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Art and design",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Jewellery, Materials and Design",
                    CourseType = "Undergraduate",
                    CourseSummary = "Develop your own creative and innovative approach to jewellery design, challenging and exploring contemporary practices through new technologies and craft techniques.",
                    CourseAwardName = "BA (Honours)",
                    UcasCode = "W721",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Art and design",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Game Design and Development",
                    CourseType = "Undergraduate",
                    CourseSummary = "Study a course with a distinctive, practice-based approach to games design – gaining a diverse skill set and useful experience within the field.",
                    CourseAwardName = "BA (Honours)",
                    UcasCode = "A112",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Art and design",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Product Design",
                    CourseType = "Undergraduate",
                    CourseSummary = "Develop a highly creative approach to producing innovative 'future-facing' products by exploring and challenging design through a series of exciting and diverse projects.",
                    CourseAwardName = "BSc (Honours)",
                    UcasCode = "D009",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Art and design",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Product Design",
                    CourseType = "Undergraduate",
                    CourseSummary = "Develop a creative and innovative approach to product design and service innovation by challenging and exploring contemporary practices through a series of exciting and diverse projects.",
                    CourseAwardName = "BA (Honours)",
                    UcasCode = "W240",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Art and design",
                    NoLongerRecruiting = false
                },
                new Course
                {
                    CourseTitle = "Digital Media Production",
                    CourseType = "Undergraduate",
                    CourseSummary = "Design and produce new media products in film, animation, interactive media, web, apps, VR, cross-media and games.",
                    CourseAwardName = "BA (Honours)",
                    UcasCode = "W212",
                    UcasPoints = 112,
                    YearOfEntry = "2027/28",
                    ModeOfAttendance = "Full-time",
                    StudyLength = "3 / 4 Years",
                    HasFoundationYear = false,
                    CourseSubject = "Art and design",
                    NoLongerRecruiting = false
                }
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }
    }
}
