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
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        void IEntityTypeConfiguration<Course_Inst>.Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            builder.HasCheckConstraint("CK_CourseInst_Evaluate", "Evaluate BETWEEN 1 AND 10");

            builder.HasOne(ci => ci.Instructor)
                   .WithMany(i => i.Course_Instructors)
                   .HasForeignKey(ci => ci.inst_ID);

            builder.HasOne(ci => ci.Course)
                   .WithMany(c => c.Course_Instructors)
                   .HasForeignKey(ci => ci.Course_ID);

        }
    }
}
