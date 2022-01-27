using System.ComponentModel;

namespace Fildelizer.Sample.V3.FormFields
{
	/// <summary>
	/// element type of form field
	/// </summary>
	public enum FormFieldEType
	{
		/// <summary>
		/// Number without decimal point
		/// </summary>
		[Description("integer")]
		Integer = 0,

		/// <summary>
		/// Number with decimal point
		/// </summary>
		[Description("decimal")]

		Decimal = 1,
		/// <summary>
		/// Date value
		/// </summary>
		[Description("date")]
		Date = 2,
	}
}
