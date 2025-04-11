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
    public class InsMangedDepartment : IEntityTypeConfiguration<Department>
    {
        void IEntityTypeConfiguration<Department>.Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(i => i.InsManger)
                 .WithOne(d => d.MangedDepartment)
                 .HasForeignKey<Department>(d => d.Manger_id)
                 .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
