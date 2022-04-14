using System.Text.Json;

namespace GraphQL.Query.Builder.Formatter.NewtonsoftJson.UnitTests;

public class Car
{
    [JsonPropertyName("id")]
    public int Identifier { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    public float Speed { get; set; }
}
