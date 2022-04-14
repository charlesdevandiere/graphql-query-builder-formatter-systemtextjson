using GraphQL.Query.Builder.Formatter.SystemTextJson;
using System.Reflection;
using Xunit;

namespace GraphQL.Query.Builder.Formatter.SystemTextJson.UnitTests;

public class SystemTextJsonPropertyNameFormatterTests
{
    [Fact]
    public void Format_ShouldReturnAttributeValue()
    {
        PropertyInfo property = typeof(Car).GetProperty(nameof(Car.Identifier));
        string value = SystemTextJsonPropertyNameFormatter.Format.Invoke(property);

        Assert.Equal("id", value);
    }

    [Fact]
    public void Format_ShouldThrowIfPropertyIfNull()
    {
        Assert.Throws<ArgumentNullExecption>(() => SystemTextJsonPropertyNameFormatter.Format.Invoke(null));
    }

    [Fact]
    public void Format_ShouldReturnPropertyNameIfThereIsNoAttribute()
    {
        PropertyInfo property = typeof(Car).GetProperty(nameof(Car.Speed));
        string value = SystemTextJsonPropertyNameFormatter.Format.Invoke(property);

        Assert.Equal(nameof(Car.Speed), value);
    }
}
