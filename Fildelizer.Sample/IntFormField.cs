using Newtonsoft.Json;

namespace Fildelizer.Sample;

public record IntFormField : IFormField
{
    [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Include)]
    public string? Name { get; init; }
    
    [JsonProperty(PropertyName = "minSize", NullValueHandling = NullValueHandling.Ignore)]
    public int? MinSize { get; init; }
    
    [JsonProperty(PropertyName = "maxSize", NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxSize { get; init; }
}