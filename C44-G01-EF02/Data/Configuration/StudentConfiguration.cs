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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        void IEntityTypeConfiguration<Student>.Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(s => s.FName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(s => s.LName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(s => s.Address)
                   .HasMaxLength(150);

            builder.HasCheckConstraint("CK_Student_Age", "Age BETWEEN 18 AND 60");

            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.Dep_Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
