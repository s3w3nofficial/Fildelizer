using Fildelizer.Sample.Extensions;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types.Sets
{
	/// <summary>
	/// FormField of type set
	/// </summary>
	public abstract class FormFieldSetBase<T> : FormFieldBase<HashSet<T>> 
	{
		internal FormFieldSetBase()
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
		public override FormFieldType Type => FormFieldType.Set;
	}
}
