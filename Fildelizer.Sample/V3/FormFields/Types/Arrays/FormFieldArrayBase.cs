using Fildelizer.Sample.Extensions;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types.Arrays
{
	/// <summary>
	/// FormField of type array
	/// </summary>
	public abstract class FormFieldArrayBase<T> : FormFieldBase<ICollection<T>> 
	{
		internal FormFieldArrayBase()
		{

		}

		/// <summary>
		/// Specifies mandatory type of elements of the array 
		/// in the value property for types array, set or range.
		/// </summary>
		[JsonIgnore]
		public abstract FormFieldEType EType { get; }

		/// <summary>
		/// Specifies mandatory type of elements of the array 
		/// in the value property for types array, set or range.
		/// </summary>
		[JsonProperty("etype", Required = Required.Always)]
		public string EItemType { get => this.EType.GetDescription(); }

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
		public override FormFieldType Type => FormFieldType.Array;
	}
}
