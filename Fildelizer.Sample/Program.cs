// See https://aka.ms/new-console-template for more information

using Fildelizer.Sample;
using Newtonsoft.Json;

var response = FormFactory.Create<SampleModel>();

Console.WriteLine(JsonConvert.SerializeObject(response, Formatting.Indented));
