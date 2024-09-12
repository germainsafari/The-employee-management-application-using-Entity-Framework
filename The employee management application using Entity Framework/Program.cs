static void Main(string[] args)
{
    var employeeService = new EmployeeService();

    // Create new employee
    var newEmployee = new Employee
    {
        FirstName = "John",
        LastName = "Doe",
        Position = "Software Engineer",
        YearsOfExperience = 5,
        Email = "john.doe@example.com",
        PhoneNumber = "123-456-7890",
        DateOfHire = DateTime.Now,
        Salary = 60000
    };
    employeeService.AddEmployee(newEmployee);

    // Display all employees
    var employees = employeeService.GetAllEmployees();
    foreach (var employee in employees)
    {
        Console.WriteLine($"{employee.FirstName} {employee.LastName}, {employee.Position}");
    }
}
