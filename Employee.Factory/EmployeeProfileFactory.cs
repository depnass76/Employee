
using System;

namespace Employee
{
    public class EmployeeProfileFactory
    {
        public static IEmployeeProvider GetEmployee(string repositoryType)
        {
            IEmployeeProvider repository ;

            switch (repositoryType)
            {
                case "IT":
                    repository = new ITEmployeeProvider();
                    break;
                case "HR":
                    repository = new HREmployeeProvider();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type");
            }


            return repository;
        }
    }
}
