namespace dotnet_graphql_demo.Models;

public class FootballTeam
{
    public int Id { get; set; }
    public required string name { get; set; }
    public required string location { get; set; }

    public FootballTeam() {}

    public FootballTeam(string _name, string _location)
    {
        name = _name;
        location = _location;
    }
}