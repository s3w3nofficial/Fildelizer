using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types.Sets
{
	/// <summary>
	/// FormField of type set
	/// </summary>
	public class FormFieldDateSet : FormFieldSetBase<DateTime>, IFormField
	{
		/// <summary>
		/// Specifies mandatory type of elements of the array 
		/// in the value property for types array, set or range.
		/// </summary>
		[JsonIgnore]
		public override FormFieldEType EType => FormFieldEType.Date; 
	}
}
