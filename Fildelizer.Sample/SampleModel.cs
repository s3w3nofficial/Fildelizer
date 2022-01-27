using System.ComponentModel.DataAnnotations;
using Fildelizer.Sample.CustomValidationAttributes;

namespace Fildelizer.Sample;

public record SampleModel
{
    [Label("name")]
    [PlaceHolder("test placeholder")]
    [MaxLength(20)]
    public string Test { get; set; } 
}