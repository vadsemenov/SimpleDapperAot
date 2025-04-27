using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.DataAccess.Abstraction;

public interface IConnectionStringStorage
{
    DbType DbType { get; }
    string ConnectionString { get; }
}