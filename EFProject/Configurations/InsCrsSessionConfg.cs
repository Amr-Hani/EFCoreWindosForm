using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFProject.Configurations
{
    internal class InsCrsSessionConfg : IEntityTypeConfiguration<CourseSession>
    {
        public void Configure(EntityTypeBuilder<CourseSession> builder)
        {
            builder.HasOne(cs => cs.Instructor)
                .WithMany(i => i.CourseSessions)
                .HasForeignKey(i => i.Ins_Id)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
