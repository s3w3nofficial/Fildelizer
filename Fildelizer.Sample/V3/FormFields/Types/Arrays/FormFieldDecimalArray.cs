namespace Fildelizer.Sample.V3.FormFields.Types.Arrays
{
	/// <summary>
	/// FormField of type array
	/// </summary>
	public class FormFieldDecimalArray : FormFieldArrayBase<decimal>, IFormField
	{
		/// <summary>
		/// Specifies mandatory type of elements of the array 
		/// in the value property for types array, set or range.
		/// </summary>
		public override FormFieldEType EType => FormFieldEType.Decimal;
	}
}
