using System.Text.Json.Serialization;

namespace Fildelizer.Sample;

public class Form
{
    public string Name { get; set; }
    public ICollection<IFormField> Fields { get; set; } = new List<IFormField>();
}