using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types
{
	/// <summary>
	/// FormField of type submit button
	/// </summary>
	public class FormFieldSubmitButton : FormFieldBase<string>, IFormField
	{
		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.SubmitButton;
	}
}
