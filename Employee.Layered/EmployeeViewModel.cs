using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Employee.Layered
{
    public class EmployeeViewModel 
    {
        
        public IEmployeeProvider repository;

        public EmployeeViewModel()
        {
            repository = EmployeeProfileFactory.GetEmployee("IT");
        }

        public IEnumerable<EmployeeProfile> people;

        public IEnumerable<EmployeeProfile> People
        {
            get { return people; }
            set
            {
                people = value;
               // RaisePropertyChanged();
            }
        }
        public void FetchEmployeeData()
        {
            People = repository.GetPeople();
        }

    }
}
