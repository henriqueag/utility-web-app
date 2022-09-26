using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManager.Api.Domain.Entities;

namespace SalesManager.Api.Provider.EntityFramework.SqlServer;

public class SaleOrderItemConfiguration : IEntityTypeConfiguration<SaleOrderItem>
{
    public void Configure(EntityTypeBuilder<SaleOrderItem> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.SaleOrder)
            .WithMany(x => x.SaleOrderItems)
            .HasForeignKey(x => x.SaleOrderId)
            .IsRequired();

        builder.HasOne(x => x.Product)
            .WithOne(x => x.SaleOrderItem)
            .IsRequired();
    }
}