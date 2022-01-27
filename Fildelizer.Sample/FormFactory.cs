namespace Fildelizer.Sample;

public static class FormFactory
{
    public static Form Create<TModel>()
    {
        var factory = new FildelizerFactory<FormBuilder, Form>(new FormBuilder());
        return factory.Create<SampleModel>();
    }
}