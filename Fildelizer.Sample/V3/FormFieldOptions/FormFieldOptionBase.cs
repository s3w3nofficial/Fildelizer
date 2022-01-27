using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFieldOptions
{
	/// <summary>
	/// Base class for Value that the user can choose from
	/// </summary>
	public abstract class FormFieldOptionBase<T>
	{
		internal FormFieldOptionBase()
		{
		}

		/// <summary>
		/// Option label. It is mandatory unless rich option info is provided (see https://confluence.alza.cz/display/Dev/Rich+options ) 
		/// </summary>
		[JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
		public string Label { get; set; }

		/// <summary>
		/// Whether is option enabled
		/// </summary>
		[JsonProperty("isEnabled", Required = Required.Always)]
		public bool IsEnabled { get; set; }

		/// <summary>
		/// Option value
		/// </summary>
		[JsonProperty("value", Required = Required.Always)]
		public T Value { get; set; }
	}
}
