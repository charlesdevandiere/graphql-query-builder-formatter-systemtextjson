using System.Text.Json.Serialization;

namespace GraphQL.Query.Builder.Formatter.SystemTextJson.UnitTests;

public class Car
{
    [JsonPropertyName("id")]
    public int Identifier { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    public float Speed { get; set; }
}
