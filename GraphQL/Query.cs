using dotnet_graphql_demo.Data;
using dotnet_graphql_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_graphql_demo.GraphQL;

public class Query
{
    public async Task<List<FootballTeam>> GetTeams([Service] AppDbContext context)
    {
        return await context.FootballTeams.ToListAsync();
    }
}