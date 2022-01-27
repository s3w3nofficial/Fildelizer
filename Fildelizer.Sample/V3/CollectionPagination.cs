using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3
{
	/// <summary>
	/// Use when you need to add special information (mostly paging) to a collection items (array). 
	/// Otherwise just use plain JSON array, it is simpler!
	/// </summary>
	public class CollectionPagination
	{
		/// <summary>
		/// Link to first page
		/// </summary>
        [JsonProperty("first", Required = Required.Always)]
        [DataMember(Name = "first")]
		public Link First { get; set; }

		/// <summary>
		/// Link to previous page
		/// </summary>
        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
		public Link Previous { get; set; }

		/// <summary>
		/// Link to next page
		/// </summary>
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
		public Link Next { get; set; }

		/// <summary>
		/// Link to last page
		/// </summary>
        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
		public Link Last { get; set; }

		/// <summary>
		/// Offset of the first item
		/// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
		public int Offset { get; set; }

		/// <summary>
		/// Items per page
		/// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
		public int Limit { get; set; }

		/// <summary>
		/// Total size of the collection
		/// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
		public int Size { get; set; }
	}
}
