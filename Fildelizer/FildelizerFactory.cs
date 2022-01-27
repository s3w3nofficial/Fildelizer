using System.ComponentModel.DataAnnotations;
using System.Reflection;
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
                var generic = typeof(IFildelizerAttributeBehaviour<>).MakeGenericType(attribute.GetType());
                var method = generic.GetMethod("GetData");

                var instances = Assembly.GetEntryAssembly().ExportedTypes
                    .Where(x => x
                        .GetInterfaces()
                        .Where(x => x.IsGenericType)
                        .Where(x => x.GetGenericTypeDefinition() == typeof(IFildelizerAttributeBehaviour<>))
                        .Where(x => x.GetGenericArguments().First() == attribute.GetType()).Any())
                    .Select(x => Activator.CreateInstance(x));

                foreach (var instance in instances)
                    metadata = ((Dictionary<string, object>) method.Invoke(instance, new [] { attribute }))
                        .Concat(metadata)
                        .ToDictionary(x => x.Key, x => x.Value);
            }
            
            this._builder.BuildProperty(property.PropertyType, "some random name", metadata);
        }

        return this._builder.Result;
    }
}