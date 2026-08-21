namespace Faculty.Domain.Entities
{
    public class StudentCourseInstructor
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Grade { get; set; } 
        public Course Course { get; set; }
        public Student Student { get; set; }
        public Instructor Instructor { get; set; }
    }
}
