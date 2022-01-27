using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types
{
	/// <summary>
	/// FormField of type date
	/// </summary>
	public class FormFieldDate : FormFieldBase<DateTime>, IFormField
	{
		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.Date;
	}
}
