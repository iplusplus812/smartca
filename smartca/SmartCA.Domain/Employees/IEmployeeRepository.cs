using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Infrastructure.RepositoryFramework;

namespace SmartCA.Domain.Employees
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
        IList<Employee> GetConstructionAdministrators();
        IList<Employee> GetPrincipals();
    }
}
