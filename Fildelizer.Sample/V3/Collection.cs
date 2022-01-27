using Newtonsoft.Json;

namespace Fildelizer.Sample.V3
{
	/// <summary>
	/// Use when you need to add special information (mostly paging) to a collection items (array). 
	/// Otherwise just use plain JSON array, it is simpler! 
	/// </summary>
	public class Collection<T>
	{
		/// <summary>
		/// ctor
		/// </summary>
		public Collection()
		{

		}

		/// <summary>
		/// ctor
		/// </summary>
		public Collection(Link self, IEnumerable<T> value, CollectionPagination pagination)
		{
			Self = self;
			Value = value;
			Pagination = pagination;
		}

		/// <summary>
		/// Link to this collection
		/// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
		public Link Self { get; set; }

		/// <summary>
		/// Pagination info when collection is paginated
		/// </summary>
        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
		public CollectionPagination Pagination { get; set; }

		/// <summary>
		/// Collection values
		/// </summary>
        [JsonProperty("value", Required = Required.Always)]
		public IEnumerable<T> Value { get; set; }
	}
}
