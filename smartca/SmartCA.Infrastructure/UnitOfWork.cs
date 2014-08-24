using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using SmartCA.Infrastructure.DomainBase;
using SmartCA.Infrastructure.RepositoryFramework;

namespace SmartCA.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<EntityBase, IUnitOfWorkRepository> addedEntities;
        private Dictionary<EntityBase, IUnitOfWorkRepository> changedEntities;
        private Dictionary<EntityBase, IUnitOfWorkRepository> deletedEntities;

        public UnitOfWork()
        {
            this.addedEntities = new Dictionary<EntityBase, IUnitOfWorkRepository>();
            this.changedEntities = new Dictionary<EntityBase, IUnitOfWorkRepository>();
            this.deletedEntities = new Dictionary<EntityBase, IUnitOfWorkRepository>();
        }

        public void RegisterAdded(EntityBase entity, IUnitOfWorkRepository repository)
        {
            this.addedEntities.Add(entity, repository);
        }

        public void RegisterChanged(EntityBase entity, IUnitOfWorkRepository repository)
        {
            this.changedEntities.Add(entity, repository);
        }

        public void RegisterRemoved(EntityBase entity, IUnitOfWorkRepository repository)
        {
            this.deletedEntities.Add(entity, repository);
        }

        public void Commit()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (EntityBase entity in this.deletedEntities.Keys)
                {
                    this.deletedEntities[entity].PersistDeletedItem(entity);
                }

                foreach (EntityBase entity in this.addedEntities.Keys)
                {
                    this.addedEntities[entity].PersistDeletedItem(entity);
                }

                foreach (EntityBase entity in this.changedEntities.Keys)
                {
                    this.changedEntities[entity].PersistDeletedItem(entity);
                }

                scope.Complete();


            }

            this.deletedEntities.Clear();
            this.changedEntities.Clear();
            this.addedEntities.Clear();
        }
    }
}
