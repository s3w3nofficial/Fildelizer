using Fildelizer.Sample.Extensions;
using Fildelizer.Sample.V3.FormFields;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3
{
	/// <summary>
	/// When client has to fill in some data and submit them. Can be a regular form that is filled in by user, 
	/// or can be used when user clicks on some choices which are technically not a form. 
	/// In some cases where user just clicks one-of-many items, 
	/// it is preferred to use just links (one link for every item), because it is simpler.
    /// Form should not be used for passing data to client. 
	/// When you need to send additional static data by the form, 
	/// create plain JSON object alongside the form (see Form with additional info example). 
	/// </summary>
	public class Form : Link
	{
		/// <summary>
		/// Link to this form
		/// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
		public Link Self { get; set; }

		/// <summary>
		/// Method with which to send the form
		/// </summary>
		[JsonIgnore]
		public Method Method { get; set; }

		/// <summary>
		/// Method with which to send the form
		/// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
		public string MethodString { get => this.Method.GetDescription(); }

		/// <summary>
		/// Form fields
		/// </summary>
        [JsonProperty("value", Required = Required.Always)]
		public ICollection<IFormField> Value { get; set; }
	}
}
