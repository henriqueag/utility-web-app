using SalesManager.Domain.Entities;

namespace SalesManager.Provider.EntityFramework.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName)
            .IsRequired()
            .HasMaxLength(Customer.FullNameMaxLength);

        builder.Property(x => x.Cpf)
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(x => x.Email)
            .IsRequired(false)
            .HasMaxLength(Customer.EmailMaxLength);

        builder.HasMany(x => x.SalesOrders)
            .WithOne(x => x.Customer);
    }
}