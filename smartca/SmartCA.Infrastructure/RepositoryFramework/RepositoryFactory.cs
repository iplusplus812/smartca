using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;
using SmartCA.Infrastructure.RepositoryFramework.Configuration;

namespace SmartCA.Infrastructure.RepositoryFramework
{
    public static class RepositoryFactory
    {
        private static Dictionary<string,object> repositories = new Dictionary<string, object>();

        public static TRepository GetRepository<TRepository, TEntity>()
            where TRepository : class, IRepository<TEntity>
            where TEntity : EntityBase
        {
            TRepository repository = default (TRepository);

            string interfaceShortName = typeof (TRepository).Name;

            if (!RepositoryFactory.repositories.ContainsKey(interfaceShortName))
            {
                var settings =
                    (RepositorySettings)
                        ConfigurationManager.GetSection(
                            RepositoryMappingConstants.RepositoryMappingsConfigurationSectioinName);
                repository =
                    Activator.CreateInstance(
                        Type.GetType(settings.RepositoryMappings[interfaceShortName].RepositoryFullTypeName)) as
                        TRepository;
                RepositoryFactory.repositories.Add(interfaceShortName, repository);
            }
            else
            {
                repository= (TRepository) RepositoryFactory.repositories[interfaceShortName];
            }
            return repository;
        }
    }
}
