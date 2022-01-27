using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Fildelizer.Sample.V3.FormFields;
using Fildelizer.Sample.V3.FormFields.Types;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.Helpers
{
	/// <summary>
	/// creates form from form models
	/// </summary>
	public static class FormFactory
	{
		/// <summary>
		/// creates form from form model
		/// </summary>
		/// <typeparam name="TFormModel"></typeparam>
		/// <param name="href"></param>
		/// <param name="appLinkType"></param>
		/// <param name="method"></param>
		/// <param name="self"></param>
		/// <returns></returns>
		public static Form CreateForm<TFormModel>(Uri href, 
			AppLinkType appLinkType, Method method, Link self = null)
		{
			var fields = new List<IFormField>();
			var properties = typeof(TFormModel).GetProperties();
			
			foreach (var property in properties)
			{
				var name = ((JsonPropertyAttribute)property
					.GetCustomAttributes(typeof(JsonPropertyAttribute), false).FirstOrDefault())?.PropertyName;
				var displayName = ((DisplayAttribute)property
					.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault())?.Name;
				var placeHolder = ((DescriptionAttribute)property
					.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault())?.Description;
				var maxLength = ((MaxLengthAttribute)property
					.GetCustomAttributes(typeof(MaxLengthAttribute), false).FirstOrDefault())?.Length;
				var minLength = ((MinLengthAttribute)property
					.GetCustomAttributes(typeof(MinLengthAttribute), false).FirstOrDefault())?.Length;
				var isRquired = ((RequiredAttribute)property
					.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault()) != null ? true : false;
				var pattern = ((RegularExpressionAttribute)property
					.GetCustomAttributes(typeof(RegularExpressionAttribute), false).FirstOrDefault())?.Pattern;

				if (property.PropertyType == typeof(string))
				{
					var field = new FormFieldString
					{
						Name = name,
						Label = displayName,
						Placeholder = placeHolder,
						IsRequired = isRquired
					};

					if (maxLength != null)
						field.MaxLength = maxLength.Value;

					if (minLength != null)
						field.MinLength = minLength.Value;

					if (pattern != null)
						field.Pattern = pattern;

					fields.Add(field);
				} 
				else if (property.PropertyType == typeof(int))
				{
					var field = new FormFieldInteger
					{
						Name = name,
						Label = displayName,
						Placeholder = placeHolder,
						IsRequired = isRquired
					};

					if (maxLength != null)
						field.MaxSize = maxLength.Value;

					if (minLength != null)
						field.MinSize = minLength.Value;

					if (pattern != null)
						field.Pattern = pattern;

					fields.Add(field);
				}
				else if (property.PropertyType == typeof(decimal))
				{
					var field = new FormFieldDecimal
					{
						Name = name,
						Label = displayName,
						Placeholder = placeHolder,
						IsRequired = isRquired
					};

					if (maxLength != null)
						field.MaxSize = maxLength.Value;

					if (minLength != null)
						field.MinSize = minLength.Value;

					if (pattern != null)
						field.Pattern = pattern;

					fields.Add(field);
				}
				else if (property.PropertyType == typeof(bool))
				{
					var field = new FormFieldBoolean 
					{
						Name = name,
						Label = displayName,
						Placeholder = placeHolder,
						IsRequired = isRquired
					};

					fields.Add(field);
				}
			}

			return new Form
			{
				Href = href,
				AppLinkType = appLinkType,
				Self = self,
				Method = method,
				Value = fields
			};
		}
	}
}
