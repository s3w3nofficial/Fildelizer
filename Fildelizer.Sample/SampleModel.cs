using System.ComponentModel.DataAnnotations;
using Fildelizer.Sample.CustomValidationAttributes;

namespace Fildelizer.Sample;

public record SampleModel
{
    [Label("some random label")]
    [PlaceHolder("test placeholder")]
    [MaxLength(20)]
    public string Test { get; set; } 
}