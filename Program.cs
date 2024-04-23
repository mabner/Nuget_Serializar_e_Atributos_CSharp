using Newtonsoft.Json;
using Nuget_Serializar_e_Atributos_CSharp.Models;

DateTime dateNow = DateTime.Now;

// object collection
List<Sales> salesList = new List<Sales>();

Sales s1 = new Sales(1, "Coral Sand N1", 180.00M, dateNow);
Sales s2 = new Sales(2, "Samsung Evo 890 Pro 1TB", 1148.00M, dateNow);

salesList.Add(s1);
salesList.Add(s2);

// serializing the list of object
string serialized = JsonConvert.SerializeObject(salesList, Formatting.Indented);

File.WriteAllText("Files/sales.json", serialized);

Console.WriteLine(serialized);
