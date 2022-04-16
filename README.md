# System.Text.Json Formatter for GraphQL Query Builder

![logo](https://raw.githubusercontent.com/charlesdevandiere/graphql-query-builder-formatter-systemtextjson/master/logo.png)

A System.Text.Json property name formatter for [GraphQL.Query.Builder](https://github.com/charlesdevandiere/graphql-query-builder-dotnet) (>= 2.0.0).

This formatter returns the [JsonPropertyNameAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonpropertynameattribute) value.

[![Build Status](https://dev.azure.com/charlesdevandiere/charlesdevandiere/_apis/build/status/charlesdevandiere.graphql-query-builder-formatter-systemtextjson?branchName=master)](https://dev.azure.com/charlesdevandiere/charlesdevandiere/_build/latest?definitionId=3&branchName=master)
![Coverage](https://img.shields.io/azure-devops/coverage/charlesdevandiere/charlesdevandiere/7/master)
[![Nuget](https://img.shields.io/nuget/v/GraphQL.Query.Builder.Formatter.SystemTextJson.svg?color=blue&logo=nuget)](https://www.nuget.org/packages/GraphQL.Query.Builder.Formatter.SystemTextJson)
[![Downloads](https://img.shields.io/nuget/dt/GraphQL.Query.Builder.Formatter.SystemTextJson.svg?logo=nuget)](https://www.nuget.org/packages/GraphQL.Query.Builder.Formatter.SystemTextJson)

## Install

```console
> dotnet add package GraphQL.Query.Builder.Formatter.SystemTextJson
```

## Usage

```csharp
public class Human
{
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }
    
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }
}

// Initialize the options
QueryOptions options = new()
{
    Formatter = SystemTextJsonPropertyNameFormatter.Format
};

// Create the query with the options
var query = new Query<Human>("humans", options)
    .AddArguments(new { id = "uE78f5hq" })
    .AddField(h => h.FirstName)
    .AddField(h => h.LastName);

Console.WriteLine("{" + query.Build() + "}");
// Output:
// {humans(id:"uE78f5hq"){firstName lastName}
```