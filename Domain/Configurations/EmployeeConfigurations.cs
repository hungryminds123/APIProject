using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(x => x.FName).HasMaxLength(200);

            builder.Property(x => x.LastName).HasMaxLength(200);

            builder.Property(x => x.Age).HasDefaultValue(18); // 

            builder.HasOne(x => x.Department).WithMany(x => x.Employee).HasForeignKey(x => x.DepartmentId);
        }
    }
}
