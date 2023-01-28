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
    public class StudendEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.FullName)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
