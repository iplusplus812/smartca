using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Domain.Companies;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Domain.Projects
{
    public class Contract: EntityBase
    {
        public Company Contractor { get; set; }
        public string ScopeOfWork { get; set; }
        public string BidPackageNumber { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? NoticeToProceedDate { get; set; }
        public decimal ContractAmount { get; set; }

        public Contract():this(null)
        {
            
        }

        public Contract(object key):base(key)
        {
            this.Contractor = new Company( );
            this.ScopeOfWork = string.Empty;
            this.BidPackageNumber = string.Empty;
            this.ContractAmount = 0;
        }
    }
}
