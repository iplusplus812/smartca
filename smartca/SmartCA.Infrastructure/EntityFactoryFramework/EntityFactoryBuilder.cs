using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.DomainBase;
using SmartCA.Infrastructure.EntityFactoryFramework.Configuration;

namespace SmartCA.Infrastructure.EntityFactoryFramework
{
    public static class EntityFactoryBuilder
    {
        private static Dictionary<string,object>factories = new Dictionary<string, object>();

        public static IEntityFactory<T> BuildFactory<T>() where T : EntityBase
        {
            IEntityFactory<T> factory = null;
            string key = typeof (T).Name;
            if (EntityFactoryBuilder.factories.ContainsKey(key))
            {
                factory = EntityFactoryBuilder.factories[key] as IEntityFactory<T>;
            }
            else
            {
                EntitySettings settings =
                    (EntitySettings)
                        ConfigurationManager.GetSection(
                            EntityMappingConstants.EntityMappingsConfigurationSectioinName);
                Type entityFactoryType = Type.GetType(settings.EntityMappings[key].EntityFactoryFullTypeName);

                factory = Activator.CreateInstance(entityFactoryType) as IEntityFactory<T>;
                EntityFactoryBuilder.factories[key] = factory;

            }

            return factory;
        }
    }
}
