// See https://aka.ms/new-console-template for more information

using Fildelizer.Sample;
using Fildelizer.Sample.V3;
using Newtonsoft.Json;

var result = FormFactory.Create<SampleModel>(AppLinkType.VideoDetail, Method.GET);

Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));