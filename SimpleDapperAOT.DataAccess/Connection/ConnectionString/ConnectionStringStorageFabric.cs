using SimpleDapperAOT.DataAccess.Abstraction;
using SimpleDapperAOT.DataAccess.Connection.ConnectionString.Postgres;
using SimpleDapperAOT.DataAccess.Connection.ConnectionString.SqlServer;
using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.DataAccess.Connection.ConnectionString;

public static class ConnectionStringStorageFabric
{
    public static IConnectionStringStorage Create(DbType dbType)
    {
        return dbType switch
        {
            DbType.Postgres => new PostgresConnectionString(),
            _ => new SqlServerConnectionString()
        };
    }
}