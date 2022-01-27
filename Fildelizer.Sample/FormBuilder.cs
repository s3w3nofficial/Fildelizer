namespace Fildelizer.Sample;

public class FormBuilder : IFildelizerBuilder<Form>
{
   private readonly Form _form;
   public FormBuilder()
   {
      this._form = new Form
      {
         Name = "test form"
      };
   }

   public void BuildStringProperty(CommonArributeValues values)
   {
      var field = new StringFormField
      {
         Name = values.Name ?? throw new ArgumentNullException(nameof(values)),
         MaxLength = values.MaxLength,
         MinLength = values.MinLength 
      };

      this._form.Fields.Add(field);
   }

   public void BuildIntProperty(CommonArributeValues values)
   {
      var field = new IntFormField
      {
         Name = values.Name,
         MaxSize = values.MaxLength,
         MinSize = values.MinLength 
      };
      
      this._form.Fields.Add(field);
   }

   public void BuildOtherProperty(Type type, CommonArributeValues values)
   {
   }

   public Form Result { get => this._form; }
}