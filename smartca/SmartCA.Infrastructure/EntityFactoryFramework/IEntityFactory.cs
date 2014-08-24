using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Infrastructure.EntityFactoryFramework
{
    public interface IEntityFactory<T> where T: EntityBase
    {
        T BuildEntity(IDataReader reander);
    }
}
