using Microsoft.Extensions.DependencyInjection;
using SimpleDapperAOT.DataAccess;
using SimpleDapperAOT.DataAccess.Abstraction;
using SimpleDapperAOT.DataAccess.Connection;
using SimpleDapperAOT.DataAccess.Connection.ConnectionString;
using SimpleDapperAOT.DataAccess.DapperQueries;
using SimpleDapperAOT.DataAccess.DapperQueries.PostgresQueries;
using SimpleDapperAOT.DataAccess.DapperQueries.SqlServerQueries;
using SimpleDapperAOT.DataAccess.Domain;

namespace SimpleDapperAOT.Main;

public class Program
{
    static void Main(string[] args)
    {
        // Ввести в командной строке для компиляции AOT приложения:
        // dotnet publish -r win-x64 -c Release
        //https://metanit.com/sharp/tutorial/24.1.php

        var services = new ServiceCollection();

        //Изменить для изменения настроек подключения и запросов к БД:
        var dbType = DbType.SqlServer;

        services.AddSingleton<IConnectionStringStorage>(p => ConnectionStringStorageFabric.Create(dbType));
        services.AddScoped<IDapperQueries>(p =>
        {
            return dbType switch
            {
                DbType.Postgres => new PostgresQueries(),
                _ => new SqlServerQueries()
            };
        });
        services.AddScoped<IDbConnectionCreator, DbConnectionCreator>();
        services.AddScoped<DapperQueriesService>();

        var serviceProvider = services.BuildServiceProvider();

        var dapperQueriesService = serviceProvider.GetService<DapperQueriesService>();
        var result = dapperQueriesService?.ExecuteSimpleQueryAsync().GetAwaiter().GetResult();

        Console.WriteLine(result?.Name + result?.Description + result?.NewDate);

        Console.Read();
    }
}