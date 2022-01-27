using Fildelizer.Sample.CustomValidationAttributes;

namespace Fildelizer.Sample;

public class LabelFildelizerAttributeBehaviour
    : IFildelizerAttributeBehaviour<LabelAttribute>
{
    public Dictionary<string, object> GetData(LabelAttribute attribute)
    {
        return new Dictionary<string, object>
        {
            { "label", attribute.Text }
        };
    }
}