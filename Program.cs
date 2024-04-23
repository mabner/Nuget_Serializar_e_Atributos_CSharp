using Newtonsoft.Json;
using Nuget_Serializar_e_Atributos_CSharp.Models;

Sales s1 = new Sales(1, "Coral Sand N1", 180.00M);

// serializing the object
string serialized = JsonConvert.SerializeObject(s1, Formatting.Indented);

File.WriteAllText("Files/sales.json", serialized);

Console.WriteLine(serialized);

