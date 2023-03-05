namespace InvoiceApp.Commons.Models;
public class Tax
{
    public int TaxId { get; set; }
    public string TaxSymbol { get; set; } = string.Empty;
    public decimal TaxValue { get; set; }
}
