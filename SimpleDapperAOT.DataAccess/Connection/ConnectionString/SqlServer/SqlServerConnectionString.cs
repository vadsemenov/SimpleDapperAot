using SimpleDapperAOT.DataAccess.Abstraction;
using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.DataAccess.Connection.ConnectionString.SqlServer;

public class SqlServerConnectionString : IConnectionStringStorage
{
    public DbType DbType => DbType.SqlServer;
    public string ConnectionString => "Server=localhost;Database=MyDb;User Id=sa;Password=131564471;TrustServerCertificate=True;";
}