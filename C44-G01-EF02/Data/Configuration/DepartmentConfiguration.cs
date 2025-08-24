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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        void IEntityTypeConfiguration<Department>.Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.ID);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(d => d.Name)
                   .IsUnique();

            builder.Property(d => d.HiringDate)
                   .HasColumnType("date");

            builder.HasCheckConstraint("CK_Department_HiringDate", "HiringDate <= GETDATE()");

            builder.HasOne(d => d.Head)
                   .WithMany()
                   .HasForeignKey(d => d.Ins_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
