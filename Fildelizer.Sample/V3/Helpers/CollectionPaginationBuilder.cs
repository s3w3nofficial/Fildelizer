namespace Fildelizer.Sample.V3.Helpers
{
	/// <summary>
	/// Builder for collection pagination
	/// </summary>
	public class CollectionPaginationBuilder
	{
		private CollectionPagination collectionPagination = new CollectionPagination();

		/// <summary>
		/// builds all links
		/// </summary>
		/// <param name="getLink"></param>
		/// <param name="offset"></param>
		/// <param name="limit"></param>
		/// <param name="size"></param>
		public void BuildLinks(GetLink getLink, int offset, int limit, int size)
		{
			collectionPagination.First = getLink(0, limit);
			collectionPagination.Previous = offset > 0 
				? getLink(Math.Max(0, offset - limit), limit)
				: null;
			collectionPagination.Next = offset < size - limit
				? getLink(Math.Min(size - limit, offset + limit), limit)
				: null;
			collectionPagination.Last = getLink(Math.Max(0, size - limit), limit);
			collectionPagination.Offset = offset;
			collectionPagination.Limit = limit;
			collectionPagination.Size = size;
		}

		/// <summary>
		/// how to get link
		/// </summary>
		/// <param name="offset"></param>
		/// <param name="limit"></param>
		/// <returns></returns>
		public delegate Link GetLink(int offset, int limit);

		/// <summary>
		/// get builded collection pagination
		/// </summary>
		/// <returns></returns>
		public CollectionPagination GetResult() => collectionPagination;
	}
}
