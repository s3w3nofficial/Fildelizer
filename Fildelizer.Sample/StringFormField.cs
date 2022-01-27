using Newtonsoft.Json;

namespace Fildelizer.Sample;

public record StringFormField : IFormField
{
    [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Include)]
    public string? Name { get; init; }
    
    [JsonProperty(PropertyName = "minLength", NullValueHandling = NullValueHandling.Ignore)]
    public int? MinLength { get; init; }
    
    [JsonProperty(PropertyName = "maxLength", NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxLength { get; init; }
}