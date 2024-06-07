using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Department : AuditEntity
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public virtual Employee Employee { get; set; }

    }

}
