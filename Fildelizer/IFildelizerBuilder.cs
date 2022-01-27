namespace Fildelizer;

public interface IFildelizerBuilder<TResponseModel>
{
    void BuildStringProperty(CommonArributeValues values);
    
    void BuildIntProperty(CommonArributeValues values);
    
    void BuildOtherProperty(Type type, CommonArributeValues values);

    TResponseModel Result { get; }
}