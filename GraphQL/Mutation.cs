using dotnet_graphql_demo.Data;
using dotnet_graphql_demo.Models;

namespace dotnet_graphql_demo.GraphQL;

public class Mutation
{
    public async Task<FootballTeam> AddTeam([Service] AppDbContext context, string _name, string _location)
    {
        var newTeam = new FootballTeam { name = _name, location = _location };
        context.FootballTeams.Add(newTeam);
        await context.SaveChangesAsync();
        return newTeam;
    }

    public async Task<FootballTeam?> UpdateTeam([Service] AppDbContext context, int id, string _name, string _location)
    {
        var team = await context.FootballTeams.FindAsync(id);
        if (team == null) return null;

        team.name = _name;
        team.location = _location;
        await context.SaveChangesAsync();
        return team;
    }

    public async Task<bool> DeleteTeam([Service] AppDbContext context, int id)
    {
        var team = await context.FootballTeams.FindAsync(id);
        if (team == null) return false;

        context.FootballTeams.Remove(team);
        await context.SaveChangesAsync();
        return true;
    }
}
