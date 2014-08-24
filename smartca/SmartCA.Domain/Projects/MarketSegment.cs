using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Domain.Projects
{
    public class MarketSegment:EntityBase
    {
        public MarketSector ParentSector { get; protected set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public MarketSegment(MarketSector parentSector,string name,string code):this(null,parentSector,name,code)
        {
            
        }

        public MarketSegment(object key, MarketSector parentSector, string name, string code) : base(key)
        {
            this.ParentSector = parentSector;
            this.Name = name;
            this.Code = code;

        }
    }
}
