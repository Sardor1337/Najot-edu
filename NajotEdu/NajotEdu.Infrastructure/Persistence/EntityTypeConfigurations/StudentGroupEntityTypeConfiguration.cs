using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NajotEdu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotEdu.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class StudentGroupEntityTypeConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.GroupStudents)
                .HasForeignKey(x => x.GroupId);

            builder.HasOne(x => x.Student)
                .WithMany(x => x.StudentGroups)
                .HasForeignKey(x => x.StudentId);
        }
    }
}
