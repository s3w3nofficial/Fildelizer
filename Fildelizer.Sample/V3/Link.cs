using Fildelizer.Sample.Extensions;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3
{
	/// <summary>
	/// Use when you need to describe link to something else, 
	/// usually API endpoint where to continue. 
	/// In other words, don't put URLs in various-named string properties, 
	/// but create link object.
	/// </summary>
	public class Link
	{
		/// <summary>
		/// The URI of the link ("API endpoint where to get more data")
		/// </summary>
        [JsonProperty("href", Required = Required.Always)]
		public Uri Href { get; set; }

		/// <summary>
		/// Optional type of referenced resource - name of the view to use
		/// </summary>
		[JsonIgnore]
		public AppLinkType AppLinkType { get; set; }

		/// <summary>
		/// Optional type of referenced resource - name of the view to use
		/// </summary>
        [JsonProperty("appLinkType", NullValueHandling = NullValueHandling.Ignore)]
		public string AppLink { get => AppLinkType.GetDescription(); }

		/// <summary>
		/// Optional web URL where the link leads (see comments by example 3 below)
		/// </summary>
        [JsonProperty("webLink", NullValueHandling = NullValueHandling.Ignore)]
		public string WebLink { get; set; }

		/// <summary>
		/// Optional label to show on the action
		/// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
		public string Label { get; set; }

		/// <summary>
		/// Optional secondary label to show on the action
		/// </summary>
        [JsonProperty("secondaryLabel", NullValueHandling = NullValueHandling.Ignore)]
		public string SecondaryLabel { get; set; }
	}
}
