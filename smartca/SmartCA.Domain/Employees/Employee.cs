using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.Domain.Employees
{
    public class Employee : Person   
    {
        public string JobTitle { get; set; }

        public Employee(object key): this(key,string.Empty,string.Empty)
        {
            
        }

        public Employee(object key,string firstName,string lastName):base(key,firstName,lastName)
        {
            this.JobTitle = string.Empty;
        }
    }
}
