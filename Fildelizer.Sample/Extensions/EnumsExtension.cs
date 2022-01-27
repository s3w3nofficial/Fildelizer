using System.ComponentModel;
using System.Reflection;

namespace Fildelizer.Sample.Extensions;

public static class EnumsExtension
{
    public static string GetDescription(this Enum value)
    {
        var attribute = value
            .GetType()
            .GetTypeInfo()
            .GetDeclaredField(value.ToString())
            .GetCustomAttribute<DescriptionAttribute>();

        return attribute == null ? value.ToString() : attribute.Description;
    }
}