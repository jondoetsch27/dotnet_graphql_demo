using dotnet_graphql_demo.Models;

namespace dotnet_graphql_demo.GraphQL;

public class Query
{
    public List<FootballTeam> GetTeams() =>
        new()
        {
            new(1, "Eagles", "Philadelphia"),
            new(2, "Cowboys", "Dallas")
        };
}