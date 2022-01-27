using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Fildelizer.Sample.V3.FormFields.Types
{
	/// <summary>
	/// FormField of type file
	/// </summary>
	public class FormFieldFile : FormFieldBase<IFormFile>, IFormField
	{
		/// <summary>
		/// Field type - see field type descriptions
		/// </summary>
		[JsonIgnore]
		public override FormFieldType Type => FormFieldType.File;
	}
}
