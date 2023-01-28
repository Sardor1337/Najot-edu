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
    internal class AttendanceEntityTypeConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.Attendances)
                .HasForeignKey(x => x.LessonId);

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Attendances)
                .HasForeignKey(x => x.StudentId);


        }
    }
}
