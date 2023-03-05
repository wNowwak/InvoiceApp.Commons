namespace InvoiceApp.Commons.Models;
public class Contractor
{
    public int ContractorId { get; set; }
    public int PersonDataId { get; set; }
    public PersonData PersonData { get; set; } = new();
    public int AddressId { get; set; }
    public Address Address { get; set; } = new();
}
