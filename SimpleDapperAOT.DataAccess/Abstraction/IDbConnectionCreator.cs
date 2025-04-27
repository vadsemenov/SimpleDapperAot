using SimpleDapperAOT.DataAccess.Domain;
using System.Data.Common;

namespace SimpleDapperAOT.DataAccess.Abstraction;

public interface IDbConnectionCreator
{
    DbType DbType { get; }

    string ConnectionString { get; }

    DbConnection Create();
}