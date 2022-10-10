using Domain.Entities;

namespace Infrastructure.Configurations;

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
