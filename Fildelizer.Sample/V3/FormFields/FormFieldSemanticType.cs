using System.ComponentModel;

namespace Fildelizer.Sample.V3.FormFields
{
    /// <summary>
    /// Semantic type of form field
    /// </summary>
	public enum FormFieldSemanticType
	{
		/// <summary>
		/// No special type
		/// </summary>
		[Description("common")]
		Common,

		/// <summary>
		/// Email
		/// </summary>
		[Description("email")]
		Email,

		/// <summary>
		/// Phone number
		/// </summary>
		[Description("phone")]
		Phone,

		/// <summary>
		/// Date without time
		/// </summary>
		[Description("date")]
		Date,

		/// <summary>
		/// Date with time
		/// </summary>
		[Description("dateTime")]
		DateTime,

		/// <summary>
		/// Time without date
		/// </summary>
		[Description("time")]
		Time,

		/// <summary>
		/// Text area
		/// </summary>
		[Description("textArea")]
		TextArea,

		/// <summary>
		/// Password
		/// </summary>
		[Description("password")]
		Password,

        /// <summary>
        /// Image
        /// </summary>
        [Description("image")]
        Image
	}
}
