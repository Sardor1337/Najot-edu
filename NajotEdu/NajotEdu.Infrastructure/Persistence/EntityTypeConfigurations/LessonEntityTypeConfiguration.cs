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
    internal class LessonEntityTypeConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.Lessons)
                .HasForeignKey(x => x.GroupId);
        }
    }
}
