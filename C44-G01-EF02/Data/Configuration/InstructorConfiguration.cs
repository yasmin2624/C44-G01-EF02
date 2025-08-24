using C44_G01_EF02.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Configuration
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        void IEntityTypeConfiguration<Instructor>.Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.ID);

            builder.Property(i => i.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(i => i.Salary)
                   .HasColumnType("decimal(10,2)");

            builder.HasCheckConstraint("CK_Instructor_Salary", "Salary > 0");

            builder.Property(i => i.HourRateBouns)
                   .HasDefaultValue(0)
                   .HasColumnType("decimal(10,2)");

            builder.HasCheckConstraint("CK_Instructor_HourRateBouns", "HourRateBouns >= 0");

            builder.HasOne(i => i.Department)
                   .WithMany(d => d.Instructors)
                   .HasForeignKey(i => i.Dept_ID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
