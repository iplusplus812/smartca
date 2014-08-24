using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Domain
{
    public class Person: EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Initials { get; set; }

        protected Person() : this(null)
        {
            
        }

        protected Person(object key) : this(key, string.Empty, string.Empty)
        {
            
        }

        protected Person(object key, string firstName, string lastName) : base(key)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Initials = string.Empty;
        }
    }
}
