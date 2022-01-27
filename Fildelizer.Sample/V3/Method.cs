using System.ComponentModel;

namespace Fildelizer.Sample.V3
{
	/// <summary>
	/// enum of http methods
	/// </summary>
	public enum Method
	{
		/// <summary>
		/// GET
		/// </summary>
		[Description("GET")]
		GET,

		/// <summary>
		/// POST
		/// </summary>
		[Description("POST")]
		POST,

		/// <summary>
		/// PUT
		/// </summary>
		[Description("PUT")]
		PUT,

		/// <summary>
		/// PATCH
		/// </summary>
		[Description("PATCH")]
		PATCH,

		/// <summary>
		/// DELETE
		/// </summary>
		[Description("DELETE")]
		DELETE,

		/// <summary>
		/// OPTIONS
		/// </summary>
		[Description("OPTIONS")]
		OPTIONS
	}
}
