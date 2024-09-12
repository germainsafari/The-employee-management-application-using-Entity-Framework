using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int EmployeeID { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Position { get; set; }

    public int YearsOfExperience { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public DateTime DateOfHire { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Salary { get; set; }
}
