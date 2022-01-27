using static Fildelizer.Sample.V3.Helpers.CollectionPaginationBuilder;

namespace Fildelizer.Sample.V3.Helpers
{
	/// <summary>
	/// Builder for collection
	/// </summary>
	/// <typeparam name="TCollection"></typeparam>
	/// <typeparam name="TValue"></typeparam>
	public class CollectionBuilder<TCollection, TValue>
		where TCollection : Collection<TValue>, new()
	{
		private TCollection collection = new TCollection();
		private GetLink getLink;

		/// <summary>
		/// ctor
		/// </summary>
		/// <param name="getLink"></param>
		/// <param name="value"></param>
		public CollectionBuilder(GetLink getLink, IEnumerable<TValue> value)
		{
			this.getLink = getLink;
			collection.Value = value;
		}

		/// <summary>
		/// Build self link
		/// </summary>
		/// <param name="offset"></param>
		/// <param name="limit"></param>
		public CollectionBuilder<TCollection, TValue> BuildSelf(int offset, int limit)
		{
			collection.Self = getLink(offset, limit);
			return this;
		}

		/// <summary>
		/// builds pagination
		/// </summary>
		public CollectionBuilder<TCollection, TValue> BuildPagination(int offset, int limit)
		{
			var collectionPaginationBuilder = new CollectionPaginationBuilder();
			collectionPaginationBuilder.BuildLinks(getLink, offset, limit, collection.Value.Count());
			collection.Pagination = collectionPaginationBuilder.GetResult();
			return this;
		}

		/// <summary>
		/// get builded collection
		/// </summary>
		public TCollection Result => collection;
	}
}
