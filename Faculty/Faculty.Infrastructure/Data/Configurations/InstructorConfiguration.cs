using Faculty.Domain;
using Faculty.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.Infrastructure.Data.Configurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
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
                .WithMany(x => x.Instructors)
                .HasForeignKey(x => x.DepartmentId);
        }
        
    }
}
