using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer : AuditEntity
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }    

    }
}
