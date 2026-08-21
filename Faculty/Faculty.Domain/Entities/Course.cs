namespace Faculty.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int DurationInWeeks { get; set; }
        public int Degree { get; set; }
        public int InstructorId { get; set; }
        public ICollection<Department> Departments { get; set; } = new HashSet<Department>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<StudentCourseInstructor> StudentCourses { get; set; } = new HashSet<StudentCourseInstructor>();
        public Instructor Instructor { get; set; }
    }
}
