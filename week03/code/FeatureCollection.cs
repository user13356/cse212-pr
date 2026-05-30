using System.Collections.Generic;
using System.Text.Json.Serialization;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary

    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }

}

// Outside FeatureCollection
public class Feature
{
    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }
}

// Outside is required of FeatureCollection
public class Properties
{
    [JsonPropertyName("mag")]
    public double? Mag { get; set; }

    [JsonPropertyName("place")]
    public string Place { get; set; }
}