using System;
using static EmployeeDetails.EmployeePersonal;

namespace EmployeeDetails
{
    public class Program
    {
        public static void Main()
        {
            Employee employees = new Employee();
            employees.GetPersonDetails();
        }
    }
}