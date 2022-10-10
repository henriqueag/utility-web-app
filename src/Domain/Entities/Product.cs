namespace Domain.Entities;

public class Product : BaseEntity
{
    public const int ProductNameMaxLength = 128;

    private Product() { }

    public Product(string productName, int stock, decimal salePrice, decimal purchasePrice, bool isActive)
    {
        ProductName = productName;
        Stock = stock;
        SalePrice = salePrice;
        PurchasePrice = purchasePrice;
        IsActive = isActive;
    }

    public string ProductName { get; private set; }
    public int Stock { get; private set; }
    public decimal SalePrice { get; private set; }
    public decimal PurchasePrice { get; private set; }
    public bool IsActive { get; private set; }
    public SaleOrderItem SaleOrderItem { get; private set; }
}
