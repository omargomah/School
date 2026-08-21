using Faculty.Domain;
using Faculty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.Infrastructure.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(Constants.MaxLengthOfName);
            builder.Property(x => x.Code).HasMaxLength(Constants.MaxLengthOfCode);

            builder.HasMany(x => x.Departments)
                .WithMany(x => x.Courses)
                .UsingEntity("DepartmentCourse");

            builder.HasOne(x => x.Instructor)
                .WithOne(x => x.Course)
                .HasForeignKey<Course>(x => x.InstructorId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
