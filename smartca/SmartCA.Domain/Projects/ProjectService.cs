using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.RepositoryFramework;

namespace SmartCA.Domain.Projects
{
    public static class ProjectService
    {
        public static IList<Project> GetAllProjects()
        {
            IProjectRepository repository = RepositoryFactory.GetRepository<IProjectRepository, Poject>();
            return repository.FindAll();
        }
    }
}
