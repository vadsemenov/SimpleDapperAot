using SimpleDapperAOT.DataAccess.Abstraction;
using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.DataAccess.Connection.ConnectionString.Postgres;

public class PostgresConnectionString : IConnectionStringStorage
{
    public DbType DbType => DbType.Postgres;
    // public string ConnectionString => "Driver={PostgreSQL ODBC Driver(UNICODE)};Server=127.0.0.1;Port=5432;Database=postgres;UID=postgres;PWD=131564471";
    // public string ConnectionString => "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=131564471";
    public string ConnectionString => "Host=localhost;Port=5432;Database=postgres;User Id=postgres;Password=131564471";
}