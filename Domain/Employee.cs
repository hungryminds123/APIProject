﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee : AuditEntity
    {
        public int Id { get; set; }

        public string FName {  get; set; }

        public string LastName { get; set; } 

        public int Age { get; set; }

        public bool IsActive { get; set; }

        public int DepartmentId { get; set; }

        public  Department Department { get; set; }

    }
}
