using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Domain.Projects
{
    public class MarketSector:EntityBase
    {
        public string Name { get; set; }
        public List<MarketSegment> Segments { get; protected set; }

        public MarketSector(string name):this(null,name)
        {
            this.Name = name;

        }

        public MarketSector(object key,string name):base(key)
        {
            this.Name = name;
            this.Segments = new List<MarketSegment>();

        }
    }
}
