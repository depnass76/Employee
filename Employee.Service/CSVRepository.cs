using Employee.Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Employee.Service
{
    public class CSVRepository : IEmployeeProfile
    {
        string path;

        public CSVRepository()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            path = AppDomain.CurrentDomain.BaseDirectory + filename;
        }

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
            var emp = new List<EmployeeProfile>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var elements = line.Split(',');
                        var employee = new EmployeeProfile()
                        {
                            Id = Int32.Parse(elements[0]),
                            GivenName = elements[1],
                            FamilyName = elements[2],
                            StartDate = DateTime.Parse(elements[3]),
                            Rating = Int32.Parse(elements[4]),
                            FormatString = elements[5],
                        };
                        emp.Add(employee);
                    }
                }
            }
            return emp;
        }

        public EmployeeProfile GetEmployee(int id)
        {
            return GetEmployee().FirstOrDefault(p => p.Id == id);
        }

        public void UpdateEmployee(int id, EmployeeProfile updatedEmployeeProfile)
        {
            throw new NotImplementedException();
        }
    }
}
