using System.Data.Common;
using Microsoft.Data.SqlClient;
using Npgsql;
using SimpleDapperAOT.DataAccess.Abstraction;
using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.DataAccess.Connection;

public class DbConnectionCreator(IConnectionStringStorage connectionStringStorage) : IDbConnectionCreator
{
    public DbType DbType { get; } = connectionStringStorage.DbType;

    public string ConnectionString { get; } = connectionStringStorage.ConnectionString;
    public DbConnection Create()
    {
        return DbType switch
        {
            DbType.Postgres => new NpgsqlConnection(ConnectionString),
            _ => new SqlConnection(ConnectionString)
        };
    }
}