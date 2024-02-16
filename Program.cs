using graphQLTest.DatabaseAsset;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AssetDbContext>(o => 
{
    var connectionString = "Server=localhost;Port=3380;Database=asset;Uid=root;Pwd=123456;Allow Zero Datetime=true;convert zero datetime=True;old guids=True;";
    o.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    o.EnableDetailedErrors();
    o.EnableSensitiveDataLogging();
});

builder.Services
    .AddGraphQLServer()
    .AddType<graphQLTest.Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .RegisterDbContext<AssetDbContext>();

var app = builder.Build();

app.MapGraphQL();

app.Run();

//[QueryType]
//public class Query
//{
//    public string Hello(string name = "World")
//        => $"Hello, {name}!";

//    public IEnumerable<Book> GetBooks()
//    {
//        var author = new Author("1");
//        yield return new Book("C# 1", author);
//        yield return new Book("C# 2", author);
//    }
//}

//public record Book(string Title, Author Author);

//public record Author(string Name);