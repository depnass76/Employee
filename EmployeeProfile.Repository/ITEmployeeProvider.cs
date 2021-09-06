
using System;
using System.Collections.Generic;

namespace Employee
{
    public class ITEmployeeProvider : IEmployeeProvider
    {
        public IEnumerable<EmployeeProfile> GetPeople()
        {
            IEnumerable<EmployeeProfile> p = new List<EmployeeProfile>()
            {
                new EmployeeProfile() { Id=1, GivenName="John", FamilyName="Koenig",
                    StartDate = new DateTime(1975, 10, 17), Rating=6,Department="IT" },
                new EmployeeProfile() { Id=2, GivenName="Dylan", FamilyName="Hunt",
                    StartDate = new DateTime(2000, 10, 2), Rating=8,Department="IT" },
                new EmployeeProfile { Id=3, GivenName="Leela", FamilyName="Turanga",
                    StartDate = new DateTime(1999, 3, 28), Rating=8,Department="IT",
                    FormatString = "{1} {0}" },
                new EmployeeProfile { Id=4, GivenName="John", FamilyName="Crichton",
                    StartDate = new DateTime(1999, 3, 19), Rating=7 ,Department="IT"},
                new EmployeeProfile { Id=5, GivenName="Dave", FamilyName="Lister",
                    StartDate = new DateTime(1988, 2, 15), Rating=9,Department="IT" },
                new EmployeeProfile { Id=6, GivenName="Laura", FamilyName="Roslin",
                    StartDate = new DateTime(2003, 12, 8), Rating=6,Department="IT"},
                new EmployeeProfile { Id=7, GivenName="John", FamilyName="Sheridan",
                    StartDate = new DateTime(1994, 1, 26), Rating=6,Department="IT" },
                new EmployeeProfile { Id=8, GivenName="Dante", FamilyName="Montana",
                    StartDate = new DateTime(2000, 11, 1), Rating=5,Department="IT" },
                new EmployeeProfile { Id=9, GivenName="Isaac", FamilyName="Gampu",
                    StartDate = new DateTime(1977, 9, 10), Rating=4,Department="IT" },
            };
            return p;
        }
    }
}
