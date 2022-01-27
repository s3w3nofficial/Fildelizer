namespace Fildelizer;

public interface IFildelizerBuilder<TResponseModel>
{
    void BuildProperty(Type propertyType, string propertyName, Dictionary<string, object> metadata);
    TResponseModel Result { get; } 
}