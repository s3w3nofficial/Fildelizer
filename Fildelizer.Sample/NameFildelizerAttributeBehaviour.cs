using Fildelizer.Sample.CustomValidationAttributes;

namespace Fildelizer.Sample;

public class NameFildelizerAttributeBehaviour
    : IFildelizerAttributeBehaviour<LabelAttribute>
{
    public Dictionary<string, object> GetData(LabelAttribute attribute)
    {
        return new Dictionary<string, object>
        {
            {"name", attribute.Text}
        };
    }
}