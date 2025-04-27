using SimpleDapperAOT.DataAccess.Abstraction;
using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.DataAccess.Connection.ConnectionString.SqlServer;

public class SqlServerConnectionString : IConnectionStringStorage
{
    public DbType DbType => DbType.SqlServer;
    public string ConnectionString => "Server=localhost;Database=MyDb;TrustServerCertificate=True;";
}