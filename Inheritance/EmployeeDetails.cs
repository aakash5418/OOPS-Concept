using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class EmployeePersonal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
        public EmployeePersonal Details()
        {
            EmployeePersonal employeePersonal = new EmployeePersonal();
            Console.WriteLine("Enter the Name : ");
            employeePersonal.Name = Console.ReadLine();

            Console.WriteLine("Enter the Id : ");
            employeePersonal.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Age : ");
            employeePersonal.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the City : ");
            employeePersonal.City = Console.ReadLine();

            return employeePersonal;
        }

        public class Employee : EmployeePersonal
        {
            public void GetPersonDetails()
            {
                EmployeePersonal person = new EmployeePersonal();
                var per = person.Details();
                Console.WriteLine(per.Name + "| " + per.Id + "| " + per.Age + "| " + per.City);
            }
        }
    }
}


