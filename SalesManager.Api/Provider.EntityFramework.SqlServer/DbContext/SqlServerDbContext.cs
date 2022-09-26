using Microsoft.EntityFrameworkCore;
using SalesManager.Api.Presentation.UnitOfWork;

namespace SalesManager.Api.Provider.EntityFramework.SqlServer;

public class SqlServerDbContext : DbContext, IUnitOfWork
{
    public SqlServerDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerDbContext).Assembly);
    }
}
