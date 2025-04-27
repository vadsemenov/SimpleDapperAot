namespace SimpleDapperAOT.DataAccess.DapperQueries.SqlServerQueries;

public class SqlServerQueries : IDapperQueries
{
    public IArticleQueries ArticlesQueries { get; } = new ArticleSqlServerQueries();
}