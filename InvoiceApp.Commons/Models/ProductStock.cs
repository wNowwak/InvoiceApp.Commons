namespace InvoiceApp.Commons.Models;
public class ProductStock
{
    public int StockId { get; set; }
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; } = new();
    public int ProductId { get; set; }
    public Product Product { get; set; } = new();
}
