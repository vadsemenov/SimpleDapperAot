using Dapper;

namespace SimpleDapperAOT.DataAccess.DapperQueries.SqlServerQueries;

[SqlSyntax(SqlSyntax.SqlServer)]
public class ArticleSqlServerQueries : IArticleQueries
{
    public string CreateTableQuery =>
        """
        CREATE TABLE Article (
            Id int primary key,
            Name varchar(300) NOT NULL,
            Description varchar(200) NOT NULL,
            NewDate datetime NOT NULL
            );
        """;

    public string InsertArticleQuery => """INSERT INTO Article (Id, Name, Description, NewDate) VALUES (@Id, @Name, @Description, @NewDate);""";

    public string SelectArticleQuery => """SELECT * FROM Article""";
}