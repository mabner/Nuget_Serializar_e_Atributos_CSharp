using Nuget_Serializar_e_Atributos_CSharp.Models;
using Newtonsoft.Json;

Sales s1 = new Sales(1, "Coral Sand N1", 180.00M);

// serializing the object
string serialized = JsonConvert.SerializeObject(s1, Formatting.Indented);

Console.WriteLine(serialized);

