using SalesManager.Domain.Entities;

namespace SalesManager.Provider.EntityFramework.Configurations;

public class IssuerEmailConfiguration : IEntityTypeConfiguration<IssuerEmail>
{
    public void Configure(EntityTypeBuilder<IssuerEmail> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.SmtpServer)
            .IsRequired()
            .HasMaxLength(IssuerEmail.SmtpServerMaxLength);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(IssuerEmail.EmailMaxLength);

        builder.Property(x => x.EmailPassword)
            .IsRequired()
            .HasMaxLength(IssuerEmail.EmailPasswordMaxLength);
    }
}
