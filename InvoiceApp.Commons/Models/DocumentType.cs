namespace InvoiceApp.Commons.Models;

public class DocumentType
{
    public int TypeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Shortcut { get; set; } = string.Empty;
}
