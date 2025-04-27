namespace SimpleDapperAOT.DataAccess.DapperQueries.PostgresQueries;

public class PostgresQueries : IDapperQueries
{
    public IArticleQueries ArticlesQueries { get; } = new ArticlePostgresQueries();
}