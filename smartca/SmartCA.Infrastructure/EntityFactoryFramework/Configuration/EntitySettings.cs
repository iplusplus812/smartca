using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.Infrastructure.EntityFactoryFramework.Configuration
{
   
    public class EntitySettings : ConfigurationSection
    {
        [ConfigurationProperty(EntityMappingConstants.ConfigurationPropertyName, IsDefaultCollection = true)]
        public EntityMappingCollection EntityMappings
        {
            get { return (EntityMappingCollection)base[EntityMappingConstants.ConfigurationPropertyName]; }
        }
    }
}
