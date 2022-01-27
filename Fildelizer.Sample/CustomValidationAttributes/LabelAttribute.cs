using System.ComponentModel.DataAnnotations;

namespace Fildelizer.Sample.CustomValidationAttributes;

public class LabelAttribute : ValidationAttribute
{
    public string Text { get; set; } = "";
    
    public LabelAttribute()
    {
        
    }

    public LabelAttribute(string text)
    {
        this.Text = text;
    }
}