namespace InvoiceApp.Commons.Models;
public class Warehouse
{
    public int WarehouseId { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int AddressId { get; set; }
    public Address Address { get; set; } = new();
    public bool IsDefault { get; set; }
}
