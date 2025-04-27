using Dapper;

namespace SimpleDapperAOT.DataAccess.DapperQueries.PostgresQueries;

[SqlSyntax(SqlSyntax.PostgreSql)]
public class ArticlePostgresQueries : IArticleQueries
{
    public string CreateTableQuery =>
        """
            CREATE TABLE Article (
            Id bigserial primary key,
            Name varchar(300) NOT NULL,
            Description text NOT NULL,
            NewDate timestamp default NULL
            );
        """;

    public string InsertArticleQuery => """INSERT INTO Article (Id, Name, Description, NewDate) VALUES (@Id, @Name, @Description, @NewDate);""";

    public string SelectArticleQuery => """SELECT * FROM Article""";
}