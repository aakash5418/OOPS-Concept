using Polymorphism;

public class EmployeeFunction : Employee
{
    public override List<Employee> Details()
    {
        Employee emp = new Employee();
        var employeeList = emp.Details();

        foreach (EmployeeDetails employeedetails in employeeList)
        {
            Console.WriteLine(employeedetails.Name + " | " + employeedetails.Address1 + " | " + employeedetails.Address2);
        }
        var empListAsc = employeeList.OrderBy(x => x.Name).ToList();
        foreach (var empDatail in empListAsc)
        {
            Console.WriteLine(empDatail.Name);
        }
        return employeeList;
    }
}
