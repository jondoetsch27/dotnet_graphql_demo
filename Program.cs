using dotnet_graphql_demo.GraphQL;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();
app.MapGraphQL();
app.Run();