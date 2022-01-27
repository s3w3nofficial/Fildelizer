using Fildelizer.Sample.Extensions;
using Fildelizer.Sample.V3.FormFieldOptions;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields
{
	/// <summary>
	/// Form fields for form
	/// </summary>
	public abstract class FormFieldBase<T> : IFormField
	{
		internal FormFieldBase()
		{
		}

		/// <summary>
		/// Field name
		/// </summary>
		[JsonProperty("name", Required = Required.Always)]
		public string Name { get; set; }

		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public abstract FormFieldType Type { get; }

		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonProperty("type", Required = Required.Always)]
		public string ItemType { get => this.Type.GetDescription(); }

		/// <summary>
		/// Field label
		/// </summary>
		[JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
		public string Label { get; set; }

		/// <summary>
		/// Field placeholder - for text (number) input fields, shown when field is empty
		/// </summary>
		[JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
		public string Placeholder { get; set; }

		/// <summary>
		/// Field value
		/// </summary>
		[JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
		public T Value { get; set; }

		/// <summary>
		/// Values that the user can choose from
		/// </summary>
		[JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
		public ICollection<IFormFieldOption> Options { get; set; }

		/// <summary>
		/// Error to be displayed on this field
		/// </summary>
        [JsonIgnore]
        public FormFieldSemanticType SemanticType { get; set; } = FormFieldSemanticType.Common;

		/// <summary>
		/// Further specifies item type. Can specify type is email/phone/... 
		/// </summary>
		[JsonProperty("semanticItemType", NullValueHandling = NullValueHandling.Ignore)]
		public string SemanticItemType { get => this.SemanticType.GetDescription(); }

		/// <summary>
		/// Error to be displayed on this field
		/// </summary>
		[JsonProperty("validationError", NullValueHandling = NullValueHandling.Ignore)]
		public string ValidationError { get; set; }

		/// <summary>
		/// Whether is field enabled
		/// </summary>
		[JsonProperty("isEnabled", Required = Required.Always)]
		public bool IsEnabled { get; set; }

		/// <summary>
		/// Specifies that field must be hidden
		/// </summary>
		[JsonProperty("isHidden", Required = Required.Always)]
		public bool IsHidden { get; set; }

		/// <summary>
		/// Specifies that field is required. When true, 
		/// client must always send back value in this field (empty string / array is OK) ????? !!!!!!!
		/// </summary>
		[JsonProperty("isRequired", Required = Required.Always)]
		public bool IsRequired { get; set; }

		/// <summary>
		/// Tells client whether this field is valid 
		/// </summary>
		[JsonProperty("isValid", Required = Required.Always)]
		public bool IsValid { get; set; }

		/// <summary>
		/// Can specify RegEx pattern that the field must match. For string fields only. 
		/// </summary>
		[JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
		public string Pattern { get; set; }

		/// <summary>
		/// Specifies shape of nested object. For object / array field types.
		/// </summary>
		[JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
		public NestedForm Form { get; set; }
	}
}
