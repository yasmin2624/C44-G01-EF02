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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        void IEntityTypeConfiguration<Topic>.Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(t => t.ID);

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(t => t.Name)
                   .IsUnique();
        }
    }
}
