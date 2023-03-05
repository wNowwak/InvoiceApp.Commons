namespace InvoiceApp.Commons.Models;
public class Employee
{
    public int EmployeeId { get; set; }
    public int PersonDataId { get; set; }
    public PersonData PersonData { get; set; } = new();
    public int AddressId { get; set; }
    public Address Address { get; set; } = new();
    public DateTime StartOfWork { get; set; }
    public decimal Salary { get; set; }
}
