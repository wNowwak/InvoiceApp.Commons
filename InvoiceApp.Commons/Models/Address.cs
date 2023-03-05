namespace InvoiceApp.Commons.Models;
public class Address
{
    public int AddressId { get; set; }
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string FlatNumber { get; set; } = string.Empty;
    public string PostCode { get; set; } = string.Empty;
}
