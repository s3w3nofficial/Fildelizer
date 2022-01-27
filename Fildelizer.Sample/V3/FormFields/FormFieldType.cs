using System.ComponentModel;

namespace Fildelizer.Sample.V3.FormFields
{
	/// <summary>
	/// Data type of form field
	/// </summary>
	public enum FormFieldType
	{
		/// <summary>
		/// Number without decimal point
		/// </summary>
		[Description("integer")]
		Integer = 0,

		/// <summary>
		/// String value
		/// </summary>
		[Description("string")]
		String = 1,

		/// <summary>
		/// Boolean true/false value
		/// </summary>
		[Description("boolean")]
		Boolean = 2,

		/// <summary>
		/// Array of unique values
		/// </summary>
		[Description("set")]
		Set = 3,

		/// <summary>
		/// Submit button
		/// </summary>
		[Description("submitButton")]
		SubmitButton = 4,

		/// <summary>
		/// Number with decimal point
		/// </summary>
		[Description("decimal")]
		Decimal = 5,

		/// <summary>
		/// Array of elements
		/// </summary>
		[Description("array")]
		Array = 6,

		/// <summary>
		/// Date and time value
		/// </summary>
		[Description("date")]
		Date = 7,

        /// <summary>
        /// Array of objects (forms).
        /// </summary>
        [Description("objectArray")]
        ObjectArray = 8,

        /// <summary>
        /// File (IFormFile)
        /// </summary>
        [Description("file")]
        File = 9,

		/// <summary>
		/// Value is an object 
		/// </summary>
		[Description("object")]
		Object = 10,

        /// <summary>
        /// Range of two decimal values
        /// </summary>
        [Description("range")]
        Range = 11,
	}
}
