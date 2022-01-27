using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Fildelizer.Sample;

public record SampleModel
{
    [JsonProperty("name")]
    [Display(Name = "name")]
    [Description("name field")]
    [Required]
    public string Name { get; init; }
    
    [JsonProperty("password")]
    [Display(Name = "password")]
    [Description("password field")]
    [MaxLength(40)]
    [MinLength((8))]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; init; }
    
    [JsonProperty("age")]
    [Display(Name = "age")]
    [Description("age field")]
    [MaxLength(Int32.MaxValue)]
    [MinLength(Int32.MinValue)]
    [Required]
    public int Age { get; init; }

    [JsonIgnore]
    public string IgnoredProperty { get; set; }
}