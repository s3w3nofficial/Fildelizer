using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types
{
	/// <summary>
	/// FormField of type boolean 
	/// </summary>
	public class FormFieldBoolean : FormFieldBase<bool>, IFormField 
	{
		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.Boolean;
	}
}
