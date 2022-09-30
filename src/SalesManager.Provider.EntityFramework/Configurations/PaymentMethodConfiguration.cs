using SalesManager.Domain.Entities;

namespace SalesManager.Provider.EntityFramework.Configurations;

public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(PaymentMethod.DescriptionMaxLength);
    }
}
