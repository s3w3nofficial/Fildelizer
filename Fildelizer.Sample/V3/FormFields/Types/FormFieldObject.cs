using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types
{
	/// <summary>
	/// FormField of type object
	/// </summary>
	public class FormFieldObject : FormFieldBase<object>, IFormField
	{
		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.Object;
	}
}
