# Kasper College Website (MyRazorApp)

**Module:** Web Development
**Student Repository:** `MyRazorApp`

## Database Implementation Statement
I have attempted and implemented the backend SQL database requirement using **ASP.NET Core Razor Pages** and **Entity Framework Core with a local SQLite database (`kaspercollege.db`)**.

- The database context (`Data/KasperDbContext.cs`) and initializer (`Data/DbInitializer.cs`) automatically create `kaspercollege.db` and seed all 24 courses from `course-list.xlsx` on first startup.
- Full **CRUD** (Create, Read, Update, Delete) functionality is implemented on the `/Courses` pages (`Pages/Courses/Index.cshtml`, `Create.cshtml`, `Edit.cshtml`, `Delete.cshtml`).

## Key Features Built
1. **Semantic HTML5 & Complete Client Content:** All text documents (`kasper-college.docx`, `for-students.rtf`, `learning resources.docx`, `Information for Business.docx`, `Information for Staff.pdf`, and `course-list.xlsx`) are structured across dedicated Razor Pages.
2. **Custom Mobile-First CSS (`wwwroot/css/site.css`):** Built from scratch with zero CSS frameworks (no Bootstrap or Tailwind), following the Kasper College brand style guide (`#0A437C` Deep Blue, `#F1A93B` Accent Gold, `#1E293B` Slate Navy) and demonstrating element, class, ID, pseudo-class, and attribute selectors.
3. **ReactJS & Vanilla JavaScript:** Includes an interactive ReactJS Course Finder (`wwwroot/js/courses-react.js`) on the Courses page and accessible mobile menu + form validation (`wwwroot/js/site.js`).
4. **Accessibility (WCAG 2.2 AA):** Includes skip-to-content links, ARIA attributes, high-contrast colours, keyboard focus rings, and 44px touch targets.

## How to Run Locally in Visual Studio Code
1. Open the `MyRazorApp` folder in Visual Studio Code.
2. Place the web-optimised images into `wwwroot/images/`.
3. Run in the terminal:
   ```bash
   dotnet restore
   dotnet run
   ```
4. Open the local URL shown in the terminal (e.g. `http://localhost:XXXX`).
