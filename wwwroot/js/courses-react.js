// Kasper College - Year 1 ReactJS Interactive Course Finder
// Uses React.createElement so no external build step or Babel compiler is needed.

(function () {
    const container = document.getElementById("react-course-app");
    if (!container || typeof React === "undefined" || typeof ReactDOM === "undefined") {
        return;
    }

    const rawData = container.getAttribute("data-courses");
    const initialCourses = rawData ? JSON.parse(rawData) : [];

    function CourseExplorer() {
        const [searchTerm, setSearchTerm] = React.useState("");
        const [subjectFilter, setSubjectFilter] = React.useState("All");
        const [levelFilter, setLevelFilter] = React.useState("All");

        const filteredCourses = initialCourses.filter(function (course) {
            const matchesSearch =
                course.CourseTitle.toLowerCase().includes(searchTerm.toLowerCase()) ||
                course.CourseSummary.toLowerCase().includes(searchTerm.toLowerCase());

            const matchesSubject =
                subjectFilter === "All" || course.CourseSubject === subjectFilter;

            const matchesLevel =
                levelFilter === "All" || course.CourseType === levelFilter;

            return matchesSearch && matchesSubject && matchesLevel;
        });

        return React.createElement(
            "div",
            null,
            // Filter Controls
            React.createElement(
                "div",
                { className: "react-controls" },
                React.createElement(
                    "div",
                    { className: "form-group" },
                    React.createElement("label", { htmlFor: "react-search" }, "Search Courses"),
                    React.createElement("input", {
                        id: "react-search",
                        type: "search",
                        placeholder: "Type e.g. Cyber Security, Games, Design...",
                        value: searchTerm,
                        onChange: function (e) { setSearchTerm(e.target.value); }
                    })
                ),
                React.createElement(
                    "div",
                    { className: "form-group" },
                    React.createElement("label", { htmlFor: "react-subject" }, "Subject Area"),
                    React.createElement(
                        "select",
                        {
                            id: "react-subject",
                            value: subjectFilter,
                            onChange: function (e) { setSubjectFilter(e.target.value); }
                        },
                        React.createElement("option", { value: "All" }, "All Subjects"),
                        React.createElement("option", { value: "Computing" }, "Computing"),
                        React.createElement("option", { value: "Art and design" }, "Art and design")
                    )
                ),
                React.createElement(
                    "div",
                    { className: "form-group" },
                    React.createElement("label", { htmlFor: "react-level" }, "Study Level"),
                    React.createElement(
                        "select",
                        {
                            id: "react-level",
                            value: levelFilter,
                            onChange: function (e) { setLevelFilter(e.target.value); }
                        },
                        React.createElement("option", { value: "All" }, "All Levels"),
                        React.createElement("option", { value: "Undergraduate" }, "Undergraduate"),
                        React.createElement("option", { value: "Postgraduate" }, "Postgraduate")
                    )
                )
            ),

            // Results Count
            React.createElement(
                "p",
                { "aria-live": "polite" },
                "Showing ",
                React.createElement("strong", null, filteredCourses.length),
                " of ",
                initialCourses.length,
                " courses."
            ),

            // Course Cards Grid
            React.createElement(
                "div",
                { className: "grid-cards" },
                filteredCourses.map(function (course) {
                    return React.createElement(
                        "article",
                        { key: course.Id, className: "card" },
                        React.createElement(
                            "span",
                            { className: course.NoLongerRecruiting ? "badge badge-closed" : "badge badge-open" },
                            course.NoLongerRecruiting ? "No Longer Recruiting" : "Open for 2027/28"
                        ),
                        React.createElement("h3", { style: { marginTop: "0.6rem" } }, course.CourseTitle + " (" + course.CourseAwardName + ")"),
                        React.createElement("p", null, course.CourseSummary),
                        React.createElement(
                            "p",
                            { className: "table-subtext" },
                            React.createElement("strong", null, "Subject: "),
                            course.CourseSubject,
                            " | ",
                            React.createElement("strong", null, "Length: "),
                            course.StudyLength,
                            course.UcasCode ? " | UCAS: " + course.UcasCode + " (" + course.UcasPoints + " pts)" : ""
                        )
                    );
                })
            )
        );
    }

    const root = ReactDOM.createRoot(container);
    root.render(React.createElement(CourseExplorer));
})();
