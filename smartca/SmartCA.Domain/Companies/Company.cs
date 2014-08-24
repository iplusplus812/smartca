using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Domain.Companies
{
    public class Company: EntityBase
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        private Address HeadquartersAddress { get; set; }

        public Company():this(null)
        {
            
        }

        public Company(object key) : base(key)
        {

        }
    }
}
