using static Fildelizer.Sample.V3.Helpers.CollectionPaginationBuilder;

namespace Fildelizer.Sample.V3.Helpers
{
	/// <summary>
	/// collection factory
	/// </summary>
	/// <typeparam name="TValue"></typeparam>
	public class CollectionFactory<TValue>
	{
		/// <summary>
		/// creates collection
		/// </summary>
		/// <param name="getLink"></param>
		/// <param name="value"></param>
		/// <param name="offset"></param>
		/// <param name="limit"></param>
		/// <returns></returns>
		public TCollection Create<TCollection>(GetLink getLink,
			IEnumerable<TValue> value, int offset, int limit)
			where TCollection : Collection<TValue>, new() 
		{
			var builder = new CollectionBuilder<TCollection, TValue>(getLink, value)
				.BuildSelf(offset, limit);

			return builder.Result;
		}

		/// <summary>
		/// creates collection with pagination
		/// </summary>
		/// <param name="getLink"></param>
		/// <param name="value"></param>
		/// <param name="offset"></param>
		/// <param name="limit"></param>
		/// <returns></returns>
		public TCollection CreateWithPagination<TCollection>(GetLink getLink,
			IEnumerable<TValue> value, int offset, int limit)
			where TCollection : Collection<TValue>, new()
		{
			var builder = new CollectionBuilder<TCollection, TValue>(getLink, value)
				.BuildSelf(offset, limit)
				.BuildPagination(offset, limit);

			return builder.Result;
		}
	}
}
