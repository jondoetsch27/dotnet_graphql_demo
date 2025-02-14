using Microsoft.EntityFrameworkCore;
using dotnet_graphql_demo.Models;

namespace dotnet_graphql_demo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<FootballTeam> FootballTeams { get; set; }
}
