using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.RepositoryFramework;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Infrastructure
{
    public interface IUnitOfWork
    {
        void RegisterAdded(EntityBase entity, IUnitOfWorkRepository repository);
        void RegisterChanged(EntityBase entity, IUnitOfWorkRepository repository);
        void RegisterRemoved(EntityBase entity, IUnitOfWorkRepository repository);
        void Commit();
    }

    
}
