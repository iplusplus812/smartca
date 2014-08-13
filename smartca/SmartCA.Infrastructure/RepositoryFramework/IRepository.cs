using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Infrastructure.RepositoryFramework
{
    public interface IRepository<T> where T:EntityBase
    {
        T FindBy(object key);
        void Add(T item);
        T this[object key] { get; set; }
        void Remove(T item);
    }
}
