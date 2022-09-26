using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManager.Api.Domain.Entities;

namespace SalesManager.Api.Provider.EntityFramework.SqlServer;

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