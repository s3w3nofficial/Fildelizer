using Fildelizer.Sample.Extensions;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types.Ranges
{
	/// <summary>
	/// Form field with int ranges
	/// </summary>
	public class FormFieldWithIntRange : FormFieldInteger, IFormField
	{
		/// <summary>
		/// Specifies mandatory type of elements of the array 
		/// in the value property for types array, set or range.
		/// </summary>
		[JsonIgnore]
		public FormFieldEType EType => FormFieldEType.Integer;

		/// <summary>
		/// Specifies mandatory type of elements of the array 
		/// in the value property for types array, set or range.
		/// </summary>
		[JsonProperty("etype", Required = Required.Always)]
		public string EItemType { get => this.EType.GetDescription(); }

		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.Range;

		/// <summary>
		/// Minimum allowed value. When field type is number, this is also number, when field type date, 
		/// it is string in the ISO 8601 format specifying minimum date.
		/// </summary>
		[JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
		public int Min { get; set; }

		/// <summary>
		/// Maximum allowed value. When field type is number, this is also number, 
		/// when field type is date, it is string in the ISO 8601 format specifying minimum date.
		/// </summary>
		[JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
		public int Max { get; set; } 
	}
}
