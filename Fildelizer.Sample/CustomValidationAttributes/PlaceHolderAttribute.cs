using System.ComponentModel.DataAnnotations;

namespace Fildelizer.Sample.CustomValidationAttributes;

public class PlaceHolderAttribute : ValidationAttribute
{
    public string Text { get; set; } = "";

    public PlaceHolderAttribute()
    {
        
    }

    public PlaceHolderAttribute(string text)
    {
        this.Text = text;
    }
}