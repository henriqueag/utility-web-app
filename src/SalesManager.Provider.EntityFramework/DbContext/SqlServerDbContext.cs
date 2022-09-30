using SalesManager.Application.UnitOfWork;

namespace SalesManager.Provider.EntityFramework;

public class SqlServerDbContext : DbContext, IUnitOfWork
{
    public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
    {        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerDbContext).Assembly);
    }
}
