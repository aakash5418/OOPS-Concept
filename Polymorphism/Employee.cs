using Polymorphism;

public class Employee : EmployeeDetails
{
    public virtual List<Employee> Details()
    {
        List<Employee> employeeList = new List<Employee>();
        for (int i = 0; i < 2; i++)
        {
            var employeeDetails = new Employee();
            Console.WriteLine("enter the name : ");
            employeeDetails.Name = Console.ReadLine();
            Console.WriteLine("enter the address1 : ");
            employeeDetails.Address1 = Console.ReadLine();
            Console.WriteLine("enter the address2 : ");
            employeeDetails.Address2 = Console.ReadLine();
            employeeList.Add(employeeDetails);

        }
        return employeeList;
    }
}