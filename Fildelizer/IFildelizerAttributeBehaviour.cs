using System.ComponentModel.DataAnnotations;

namespace Fildelizer;

public interface IFildelizerAttributeBehaviour<TAttrinute>
    where TAttrinute : ValidationAttribute
{
    Dictionary<string, object> GetData(TAttrinute attribute);
}