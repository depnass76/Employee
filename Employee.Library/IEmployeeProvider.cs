
using System.Collections.Generic;

namespace Employee
{
    public interface IEmployeeProvider
    {
        IEnumerable<EmployeeProfile> GetPeople();
    }
}
