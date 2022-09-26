using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManager.Api.Domain.Entities;

namespace SalesManager.Api.Provider.EntityFramework.SqlServer;

public class SaleOrderConfiguration : IEntityTypeConfiguration<SaleOrder>
{
    public void Configure(EntityTypeBuilder<SaleOrder> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.SalesOrders)
            .HasForeignKey(x => x.CustomerId)
            .IsRequired();

        builder.HasOne(x => x.PaymentMethod)
            .WithMany(x => x.SalesOrders)
            .HasForeignKey(x => x.PaymentMethodId)
            .IsRequired();

        builder.HasMany(x => x.SaleOrderItems)
            .WithOne(x => x.SaleOrder)
            .HasForeignKey(x => x.SaleOrderId)
            .IsRequired();
    }
}