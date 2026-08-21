namespace Faculty.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public int DepartmentId { get; set; }    
        public Department Department { get; set; }    
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public ICollection<StudentCourseInstructor> StudentCourseInstructors { get; set; } = new HashSet<StudentCourseInstructor>();
    }
}
