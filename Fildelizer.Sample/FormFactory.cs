using Fildelizer.Sample.V3;

namespace Fildelizer.Sample;

public class FormFactory
{
    public static Form Create<T>(AppLinkType appLinkType, Method method)
        where T : class
    {
        var builder = new FormBuilder();
        var factory = new FildelizerFactory<FormBuilder, Form>(builder);

        var result = factory.Create<T>();

        result.AppLinkType = appLinkType;
        result.Method = method;

        return result;
    }
}