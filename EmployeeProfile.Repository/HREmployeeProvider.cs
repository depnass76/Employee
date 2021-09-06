using System;
using System.Collections.Generic;


namespace Employee
{
    public class HREmployeeProvider:IEmployeeProvider
    {
        public IEnumerable<EmployeeProfile> GetPeople()
        {
            IEnumerable<EmployeeProfile> p = new List<EmployeeProfile>()
            {
                new EmployeeProfile() { Id=1, GivenName="Dave", FamilyName="Woyane",
                    StartDate = new DateTime(1975, 10, 17), Rating=6,Department="HR" },
                new EmployeeProfile() { Id=2, GivenName="Colman", FamilyName="Kerry",
                    StartDate = new DateTime(2000, 10, 2), Rating=8,Department="HR" },
                new EmployeeProfile { Id=3, GivenName="Steve", FamilyName="Doga",
                    StartDate = new DateTime(1999, 3, 28), Rating=8,Department="HR",
                    FormatString = "{1} {0}" },
                new EmployeeProfile { Id=4, GivenName="John", FamilyName="Criton",
                    StartDate = new DateTime(1999, 3, 19), Rating=7 ,Department="HR"},
                new EmployeeProfile { Id=5, GivenName="Dave", FamilyName="Somay",
                    StartDate = new DateTime(1988, 2, 15), Rating=9,Department="HR" },
                new EmployeeProfile { Id=6, GivenName="katie", FamilyName="Rosi",
                    StartDate = new DateTime(2003, 12, 8), Rating=6,Department="HR"},
                new EmployeeProfile { Id=7, GivenName="John", FamilyName="Sidan",
                    StartDate = new DateTime(1994, 1, 26), Rating=6,Department="HR" },
                new EmployeeProfile { Id=8, GivenName="Robert", FamilyName="Mana",
                    StartDate = new DateTime(2000, 11, 1), Rating=5,Department="HR" },
                new EmployeeProfile { Id=9, GivenName="Micheal", FamilyName="Gau",
                    StartDate = new DateTime(1977, 9, 10), Rating=4,Department="HR" },
            };
            return p;
        }
    }
}
