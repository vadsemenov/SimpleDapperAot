namespace SimpleDapperAOT.DataAccess.DapperQueries;

public interface IArticleQueries
{
    string CreateTableQuery { get; }
    string InsertArticleQuery { get; }
    string SelectArticleQuery { get; }
}