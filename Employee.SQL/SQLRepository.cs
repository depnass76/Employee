using Employee.Library;
using System;
using System.Collections.Generic;

namespace Employee.SQL
{
    public class SQLRepository : IEmployeeProfile
    {
        public void AddEmployee(EmployeeProfile newEmployeeProfile)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeProfile> GetEmployee()
        {
            throw new NotImplementedException();
        }

        public EmployeeProfile GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(int id, EmployeeProfile updatedEmployeeProfile)
        {
            throw new NotImplementedException();
        }
    }
}
