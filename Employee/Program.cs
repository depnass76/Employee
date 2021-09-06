
using System;


namespace Employee
{
    class Program
    {

        static void Main()
        {
            


            Console.WriteLine("\r\nEnter department to display Employees Name > ");
            while (true)
            {
                Console.Write("\r\nTechnologie=IT,Human Resources=HR or q to exit >:");
                string repositoryType = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("ID" + " | " + "Given Name" + " | " + "Department" + " | " + "Rating");
                
                if (repositoryType == "q")
                {
                    break;
                }
                IEmployeeProvider repository = EmployeeProfileFactory.GetEmployee(repositoryType);
                var people = repository.GetPeople();

                foreach (var person in people)
                {
                    
                    
                    Console.WriteLine(person.Id + "    " + person.GivenName + "       " + person.Department+ "          "+person.Rating);
                }

            }

        }
        

    }
       
}
