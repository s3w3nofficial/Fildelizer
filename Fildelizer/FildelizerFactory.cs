using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Fildelizer;

public class FildelizerFactory<TBuilder, TResponseModel>
    where TBuilder : IFildelizerBuilder<TResponseModel>
{
    private readonly TBuilder _builder;

    public FildelizerFactory(TBuilder builder)
    {
        _builder = builder;
    }

    public TResponseModel Create<TModel>()
        where TModel : class 
    {
        var properties = typeof(TModel).GetProperties();

        foreach (var property in properties)
        {
            if (property.GetCustomAttributes(typeof(JsonIgnoreAttribute), false).FirstOrDefault() is not null)
                continue;

            var attributes = property.GetCustomAttributes(typeof(ValidationAttribute), true);
            var metadata = new Dictionary<string, object>();
            foreach (var attribute in attributes)
            {
            }
            
            this._builder.BuildProperty(property.GetType(), "some random name", metadata);
        }

        return this._builder.Result;
    }
}