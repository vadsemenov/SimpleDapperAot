using Dapper;
using SimpleDapperAOT.DataAccess.Abstraction;
using SimpleDapperAOT.DataAccess.DapperQueries;
using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.DataAccess;

[DapperAot]
public class DapperQueriesService(IDbConnectionCreator connectionCreator, IDapperQueries dapperQueries)
{
    public async Task<Article?> ExecuteSimpleQueryAsync()
    {
        await using var connection = connectionCreator.Create();

        await connection.ExecuteAsync(dapperQueries.ArticlesQueries.CreateTableQuery);

        var article = new Article
        {
            Id = 2,
            Name = "First Article",
            Description = "First description",
            NewDate = DateTime.UtcNow,
        };

        await connection.ExecuteAsync(dapperQueries.ArticlesQueries.InsertArticleQuery, article);

        return await connection.QuerySingleOrDefaultAsync<Article>(dapperQueries.ArticlesQueries.SelectArticleQuery);
    }
}