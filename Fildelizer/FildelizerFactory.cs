using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Fildelizer;

/// <summary>
/// Creates response model using fildelizer builder
/// and supplied model
/// </summary>
/// <typeparam name="TBuilder"></typeparam>
/// <typeparam name="TResponseModel"></typeparam>
public class FildelizerFactory<TBuilder, TResponseModel>
    where TBuilder : IFildelizerBuilder<TResponseModel>
{
    private readonly TBuilder _builder;
    public FildelizerFactory(TBuilder builder)
    {
        this._builder = builder;
    }
    
    public TResponseModel Create<TModel>()
        where TModel : class 
    {
        var properties = typeof(TModel).GetProperties();

        foreach (var property in properties)
        {
            if (property.GetCustomAttributes(typeof(JsonIgnoreAttribute), false).FirstOrDefault() is not null)
                continue;
            
            var name = ((JsonPropertyAttribute)property
                .GetCustomAttributes(typeof(JsonPropertyAttribute), false).FirstOrDefault())?.PropertyName;
            var displayName = ((DisplayAttribute)property
                .GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault())?.Name;
            var placeHolder = ((DescriptionAttribute)property
                .GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault())?.Description;
            var maxLength = ((MaxLengthAttribute)property
                .GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault())?.Length;
            var minLength = ((MinLengthAttribute)property
                .GetCustomAttributes(typeof(MinLengthAttribute), false).FirstOrDefault())?.Length;
            var isRquired = ((RequiredAttribute)property
                .GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault()) != null ? true : false;
            var pattern = ((RegularExpressionAttribute)property
                .GetCustomAttributes(typeof(RegularExpressionAttribute), false).FirstOrDefault())?.Pattern;

            var values = new CommonArributeValues
            {
                Name = name,
                Pattern = pattern,
                Placeholder = placeHolder,
                DisplayName = displayName,
                IsRequired = isRquired,
                MaxLength = maxLength,
                MinLength = minLength
            };

            if (property.PropertyType == typeof(string))
                this._builder.BuildStringProperty(values);
            else if(property.PropertyType == typeof(int))
                this._builder.BuildIntProperty(values);
            else
                this._builder.BuildOtherProperty(property.PropertyType, values);
        }

        return this._builder.Result;
    }
}