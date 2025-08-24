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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        void IEntityTypeConfiguration<Course>.Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.ID);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(c => c.Name)
                   .IsUnique();

            builder.Property(c => c.Description)
                   .HasMaxLength(255);

            builder.HasCheckConstraint("CK_Course_Duration", "Duration > 0");

            builder.HasOne(c => c.Topic)
                   .WithMany(t => t.Courses)
                   .HasForeignKey(c => c.Top_ID)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
