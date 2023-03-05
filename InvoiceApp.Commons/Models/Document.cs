namespace InvoiceApp.Commons.Models;

public class Document
{
    public int DocumentId { get; set; }
    public int TypeId { get; set; }
    public DocumentType Type { get; set; } = new();
    public string DocumentNumber { get; set; } = string.Empty;
    public decimal TotalValue { get; set; }
    public int ContractorId { get; set; }
    public Contractor Contractor { get; set; } = new();
    public int AddressId { get; set; }
    public Address Address { get; set; } = new();
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; } = new();
    public DateTime DateOfIssue { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = new();
    public string Remarks { get; set; } = string.Empty;
    public IList<DocumentItem> Items { get; set; } = new List<DocumentItem>();
}
