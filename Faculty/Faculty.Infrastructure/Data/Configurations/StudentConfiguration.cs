using Faculty.Domain;
using Faculty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Faculty.Infrastructure.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FName).HasMaxLength(Constants.MaxLengthOfName);
            builder.Property(x => x.LName).HasMaxLength(Constants.MaxLengthOfName);
            builder.Property(x => x.Email).HasMaxLength(Constants.MaxLengthOfEmail);
            builder.ComplexProperty(x => x.Address, b =>
            {
                b.Property(z => z.Street).HasMaxLength(Constants.MaxLengthOfStreetOrCountryOrCity);
                b.Property(z => z.City).HasMaxLength(Constants.MaxLengthOfStreetOrCountryOrCity);
                b.Property(z => z.Country).HasMaxLength(Constants.MaxLengthOfStreetOrCountryOrCity);
            });

            builder.HasOne(x => x.Department)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.DepartmentId);

            builder.HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity<StudentCourseInstructor>();
        }
    }
}
