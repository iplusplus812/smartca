using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.Infrastructure.EntityFactoryFramework.Configuration
{
    
    public sealed class EntityMappingElement : ConfigurationElement
    {
        [ConfigurationProperty(EntityMappingConstants.EntityFactoryShortTypeNameAttributeName, IsKey = true,
            IsRequired = true)]
        public string EntityFactoryShortTypeName
        {
            get { return (string)this[EntityMappingConstants.EntityFactoryShortTypeNameAttributeName]; }
            set { this[EntityMappingConstants.EntityFactoryShortTypeNameAttributeName] = value; }
        }

        [ConfigurationProperty(EntityMappingConstants.EntityFactoryFullTypeNameAttributeName, IsRequired = true)]
        public string EntityFactoryFullTypeName
        {
            get { return (string)this[EntityMappingConstants.EntityFactoryFullTypeNameAttributeName]; }
            set { this[EntityMappingConstants.EntityFactoryFullTypeNameAttributeName] = value; }
        }
    }
}
