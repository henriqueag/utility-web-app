using Microsoft.AspNetCore.Mvc;
using SalesManager.Api.Attributes;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Repository;
using SalesManager.Provider.EntityFramework;

namespace SalesManager.Api.Controllers;

[ApiController]
[Route(ResourcesRoute)]
public class SaleOrderResourcesController : ControllerBase
{
    private const string ResourcesRoute = "api/sale-order/resources";

    private readonly IRepositoryBase<SaleOrder> _repositorySaleOrder;
    private readonly IRepositoryBase<Product> _repositoryProduct;
    private readonly IRepositoryBase<Customer> _repositoryCustomer;
    private readonly IRepositoryBase<PaymentMethod> _repositoryPayment;
    private readonly ILogger<SaleOrderResourcesController> _logger;
    private readonly SqlServerDbContext _context;

    public SaleOrderResourcesController(IRepositoryBase<SaleOrder> repositorySaleOrder, IRepositoryBase<Product> repositoryProduct, IRepositoryBase<Customer> repositoryCustomer, IRepositoryBase<PaymentMethod> repositoryPayment, ILogger<SaleOrderResourcesController> logger, SqlServerDbContext context)
    {
        _repositorySaleOrder = repositorySaleOrder;
        _repositoryProduct = repositoryProduct;
        _repositoryCustomer = repositoryCustomer;
        _repositoryPayment = repositoryPayment;
        _logger = logger;
        _context = context;
    }

    [UnitOfWork]
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] SaleOrderData saleOrderData, CancellationToken cancellationToken)
    {
        _logger.LogInformation("A operação de cadastro de uma nova venda foi chamada recebendo {@SaleOrderData} como entrada", saleOrderData);

        var products = (await _repositoryProduct.GetAll(cancellationToken)).ToList();
        var customers = (await _repositoryCustomer.GetAll(cancellationToken)).ToList();
        var payments = (await _repositoryPayment.GetAll(cancellationToken)).ToList();

        var items = new SaleOrderItemData[]
        {
            new()
            {
                ProductData = products[1].ToProductData(),
                Quantity = 2,
                UnitAmount = products[1].SalePrice
            },
            new()
            {
                ProductData = products[0].ToProductData(),
                Quantity = 2,
                UnitAmount = products[0].SalePrice
            },
            new()
            {
                ProductData = products[2].ToProductData(),
                Quantity = 2,
                UnitAmount = products[2].SalePrice
            }
        };

        saleOrderData = new()
        {
            CustomerData = customers[0],
            PaymentMethodData = payments[1].ToPaymentMethodData(),
            SaleOrderItemsData = items,
            Discount = 15
        };

        saleOrderData.CalculateSubtotal();
        saleOrderData.CalculateGrandTotal();

        var saleOrder = saleOrderData.ToSaleOrder();

        await _repositorySaleOrder.Create(saleOrder, cancellationToken);

        return Created(Request.Path.Value, saleOrder.Id);
    }

    [HttpGet("{saleOrderId:Guid}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid saleOrderId, CancellationToken cancellationToken)
    {
        _logger.LogInformation("A operação de busca por ordem de venda por identificador foi chamada recebendo como entrada o id {SaleOrderId}", saleOrderId);

        var saleOrder = await _context.Set<SaleOrder>()
            .Include(x => x.Customer)
            .Include(x => x.PaymentMethod)
            .Include(x => x.SaleOrderItems)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == saleOrderId, cancellationToken);


        if (saleOrder is null)
        {
            return NotFound(new
            {
                Code = "get-by-id.entity-not-found",
                Message = "A busca não retornou resultados"
            });
        }

        var items = saleOrder.SaleOrderItems.Select(item =>
        {
            var product = _repositoryProduct.GetById(item.ProductId, cancellationToken).GetAwaiter().GetResult();
            return new
            {
                product.ProductName,
                item.UnitAmount,
                item.Quantity
            };
        });

        return Ok(new
        {
            saleOrder.Customer.FullName,
            saleOrder.ReleaseDate,
            items,
            saleOrder.GrandTotal
        });
    }
}

public class SaleOrderData
{
    public Guid Id { get; set; }
    public Customer CustomerData { get; set; }
    public PaymentMethodData PaymentMethodData { get; set; }
    public IList<SaleOrderItemData> SaleOrderItemsData { get; set; }
    public decimal Discount { get; set; }
    public decimal Addition { get; set; }
    public decimal Subtotal { get; private set; }
    public decimal GrandTotal { get; private set; }

    public void CalculateSubtotal()
    {
        Subtotal = SaleOrderItemsData.ToList()
            .Sum(item => item.Quantity * item.UnitAmount);
    }

    public void CalculateGrandTotal()
    {
        var calculatedDiscount = Subtotal * (Discount / 100);
        GrandTotal = Subtotal - calculatedDiscount;
    }
}

public class PaymentMethodData
{
    public string Description { get; set; }
    public bool AllowsDiscount { get; set; }
}

public class SaleOrderItemData
{
    public ProductData ProductData { get; set; }
    public int Quantity { get; set; }
    public decimal UnitAmount { get; set; }
}

public class ProductData
{
    public string ProductName { get; set; }
    public int Stock { get; set; }
    public decimal SalePrice { get; set; }
    public decimal PurchasePrice { get; set; }
    public bool IsActive { get; set; }
}

public static class DtosExtensions
{
    public static PaymentMethod ToPaymentMethod(this PaymentMethodData paymentMethodData)
    {
        return new PaymentMethod(paymentMethodData.Description, paymentMethodData.AllowsDiscount);
    }

    public static PaymentMethodData ToPaymentMethodData(this PaymentMethod paymentMethod)
    {
        return new PaymentMethodData { Description = paymentMethod.Description, AllowsDiscount = paymentMethod.AllowsDiscount };
    }

    public static Product ToProduct(this ProductData productData)
    {
        return new Product(productData.ProductName, productData.Stock, productData.SalePrice, productData.PurchasePrice, productData.IsActive);
    }

    public static ProductData ToProductData(this Product product)
    {
        return new ProductData
        {
            ProductName = product.ProductName,
            Stock = product.Stock,
            PurchasePrice = product.PurchasePrice,
            SalePrice = product.SalePrice,
            IsActive = product.IsActive
        };
    }

    public static SaleOrderItem ToSaleOrderItem(this SaleOrderItemData saleOrderItemData)
    {
        return new SaleOrderItem(saleOrderItemData.ProductData.ToProduct(), saleOrderItemData.Quantity, saleOrderItemData.UnitAmount);
    }

    public static SaleOrder ToSaleOrder(this SaleOrderData saleOrderData)
    {
        return new SaleOrder(saleOrderData.CustomerData,
            saleOrderData.PaymentMethodData.ToPaymentMethod(),
            saleOrderData.SaleOrderItemsData.Select(item => item.ToSaleOrderItem()).ToList(),
            saleOrderData.Discount,
            saleOrderData.Addition,
            saleOrderData.Subtotal,
            saleOrderData.GrandTotal
            );
    }
}