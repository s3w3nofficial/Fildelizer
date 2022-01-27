using Fildelizer.Sample.V3;
using Fildelizer.Sample.V3.FormFields;
using Fildelizer.Sample.V3.FormFields.Types;

namespace Fildelizer.Sample;

public class FormBuilder : IFildelizerBuilder<Form>
{
    private Form _form = new ();
    public FormBuilder()
    {
        this._form.Value = new List<IFormField>();
    }

    public void BuildProperty(Type propertyType, string propertyName, Dictionary<string, object> metadata)
    {
        if (propertyType == typeof(string))
        {
            this._form.Value.Add(new FormFieldString
            {
               Name = propertyName,
               Label = metadata.ContainsKey("label") ? metadata["label"] as string : null
            });
        }
    }

    public void BuildPropertyWithValue<T>(Type propertyType, string propertyName, T propertyValue, Dictionary<string, object> metadata)
    {
        throw new NotImplementedException();
    }

    public Form Result { get => this._form; }
}