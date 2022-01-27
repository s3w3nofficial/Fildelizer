using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types
{
	/// <summary>
	/// FormField of type string
	/// </summary>
	public class FormFieldString : FormFieldBase<string>, IFormField
	{
		/// <summary>
		/// Minimum allowed length of the value (for strings)
		/// </summary>
		[JsonProperty("minLength", NullValueHandling = NullValueHandling.Ignore)]
		public int MinLength { get; set; }

		/// <summary>
		/// Maximum allowed length of the value (for strings)
		/// </summary>
		[JsonProperty("maxLength", NullValueHandling = NullValueHandling.Ignore)]
		public int MaxLength { get; set; }

		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.String;
	}
}
