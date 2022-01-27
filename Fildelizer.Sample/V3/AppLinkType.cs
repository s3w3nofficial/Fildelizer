using System.ComponentModel;

namespace Fildelizer.Sample.V3
{
	/// <summary>
	/// App Action Type
	/// </summary>
	public enum AppLinkType
	{
		/// <summary>
		/// Videos action
		/// </summary>
		[Description("video")]
		Video,

		/// <summary>
		/// Video detail action
		/// </summary>
		[Description("videoDetail")]
		VideoDetail,

		/// <summary>
		/// Navigation action
		/// </summary>
		[Description("navigation")]
		Navigation
	}
}
