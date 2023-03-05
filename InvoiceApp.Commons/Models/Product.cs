namespace InvoiceApp.Commons.Models;
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public decimal DefaultPrice { get; set; }
    public int MeasureUnitId { get; set; }
    public MeasureUnit MeasureUnit { get; set; } = new();
    public int TaxId { get; set; }
    public Tax Tax { get; set; } = new();
}
