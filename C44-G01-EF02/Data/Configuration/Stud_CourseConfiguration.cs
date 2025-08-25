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
    internal class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        void IEntityTypeConfiguration<Stud_Course>.Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            builder.HasCheckConstraint("CK_StudCourse_Grade", "Grade BETWEEN 0 AND 100");

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.Stud_Courses)
                   .HasForeignKey(sc => sc.stud_ID);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.Stud_Courses)
                   .HasForeignKey(sc => sc.Course_ID);

        }
    }
}
