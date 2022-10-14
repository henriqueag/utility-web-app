using Domain.Interfaces.Contracts;

namespace Domain.Entities;

public class SaleOrder : IHasUniqueKey
{
    private SaleOrder() { }

    public SaleOrder(Customer customer, PaymentMethod paymentMethod, IList<SaleOrderItem> saleOrderItems, decimal discount, decimal addition, decimal subtotal, decimal grandTotal)
    {
        Id = Guid.NewGuid();
        Customer = customer;
        PaymentMethod = paymentMethod;
        SaleOrderItems = saleOrderItems;
        ReleaseDate = DateTime.Now;
        Discount = discount;
        Addition = addition;
        Subtotal = subtotal;
        GrandTotal = grandTotal;
    }

    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public Customer Customer { get; private set; }
    public Guid PaymentMethodId { get; private set; }
    public PaymentMethod PaymentMethod { get; private set; }
    public IList<SaleOrderItem> SaleOrderItems { get; private set; }
    public DateTime ReleaseDate { get; private set; }
    public decimal Discount { get; private set; }
    public decimal Addition { get; private set; }
    public decimal Subtotal { get; private set; }
    public decimal GrandTotal { get; private set; }
}