using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types
{
	/// <summary>
	/// FormField of type integer
	/// </summary>
	public class FormFieldInteger : FormFieldBase<int>, IFormField
	{
		/// <summary>
		/// Minimum allowed value size (for arrays and sets)
		/// </summary>
		[JsonProperty("minSize", NullValueHandling = NullValueHandling.Ignore)]
		public int MinSize { get; set; }

		/// <summary>
		/// Maximum allowed value size (for arrays and sets)
		/// </summary>
		[JsonProperty("maxSize", NullValueHandling = NullValueHandling.Ignore)]
		public int MaxSize { get; set; }

		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.Integer;
	}
}
