using Fildelizer.Sample.V3.FormFields;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3
{
	/// <summary>
	/// Specifies shape of nested object. For object / array field types.
	/// </summary>
	public class NestedForm
	{
		/// <summary>
		/// Form fields
		/// </summary>
		[JsonProperty("value", Required = Required.Always)]
		public ICollection<IFormField> Value { get; set; }
	}
}
