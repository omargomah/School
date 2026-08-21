using Faculty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
namespace Faculty.Infrastructure.Data.Configurations
{
    public class StudentCourseInstructorConfiguration : IEntityTypeConfiguration<StudentCourseInstructor>
    {
        public void Configure(EntityTypeBuilder<StudentCourseInstructor> builder)
        {
            builder.Property(x => x.StartDate).HasDefaultValueSql("GETDATE()");


            builder.HasOne(e => e.Student)
                .WithMany(s => s.StudentCourseInstructors)
                .HasForeignKey(e => e.StudentId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(e => e.CourseId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Instructor)
                .WithMany(c => c.StudentCourseInstructors)
                .HasForeignKey(e => e.InstructorId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
