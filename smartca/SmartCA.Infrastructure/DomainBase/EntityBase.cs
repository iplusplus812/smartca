using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.Infrastructure.DomainBase
{
    public abstract class EntityBase
    {
        protected  EntityBase() : this(null)
        {
            
        }

        protected  EntityBase(object key)
        {
            this.Key = key;
        }

        public object Key { get; private set; }

        public override bool Equals(object entity)
        {
            if (entity == null || !(entity is EntityBase))
            {
                return false;
            }
            
            return (this == (EntityBase)entity);
        }

        public static bool operator==(EntityBase entity1, EntityBase entity2)
        {
            if ((object) entity1 == null && (object) entity2 == null)
            {
                return true;
            }
            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            return !(entity1.Key != entity2.Key);
        }

        public static bool operator !=(EntityBase entity1, EntityBase entity2)
        {
            return !(entity1 == entity2);
        }

        public override int GetHashCode()
        {
            if (this.Key != null)
            {
                return this.Key.GetHashCode();
            }

            return 0;
        }
    }
}
