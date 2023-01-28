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
    public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(p => p.Teacher)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.TeacherId);


        }
    }
}
