using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.RepositoryFramework;

namespace SmartCA.Domain.Projects
{
    interface IProjectRepository: IRepository<Project>
    {
        IList<Project> FindBy(object sector, object segment, bool completed);
    }
}
