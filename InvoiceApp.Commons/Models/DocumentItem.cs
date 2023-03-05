namespace InvoiceApp.Commons.Models;
public class DocumentItem
{
    public int DocumentItemId { get; set; }
    public int DocumentId { get; set; }
    public Document Document { get; set; } = new();
    public int ProductId { get; set; }
    public Product Product { get; set; } = new();
    public decimal Quantity { get; set; }
    public int TaxId { get; set; }
    public Tax Tax { get; set; } = new();
    public decimal NetPrice { get; set; }
    public int Position { get; set; }
}
