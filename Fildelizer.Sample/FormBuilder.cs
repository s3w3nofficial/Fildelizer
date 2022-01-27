using Fildelizer.Sample.V3;
using Fildelizer.Sample.V3.FormFields.Types;

namespace Fildelizer.Sample;

public class FormBuilder : IFildelizerBuilder<Form>
{
    private Form _form;
    public FormBuilder()
    {
        this._form = new Form();
    }

    public void BuildProperty(Type propertyType, string propertyName, Dictionary<string, object> metadata)
    {
        if (propertyType == typeof(string))
        {
            this._form.Value.Add(new FormFieldString
            {
               Name = propertyName,
               Label = metadata["label"]?.ToString()
            });
        }
    }

    public Form Result { get => _form; }
}