using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Nuget_Serializar_e_Atributos_CSharp.Models;

// -- Deserializing --
string fileContent = File.ReadAllText("Files/sales.json");

List<Sales> salesList = JsonConvert.DeserializeObject<List<Sales>>(fileContent);

foreach (Sales sales in salesList)
{
    Console.WriteLine(
        $"ID: {sales.Id}, Item: {sales.Product}"
            + $"Price: {sales.Price}. Date: {sales.SalesDate.ToString("dd/MM/yyyy HH:mm")}"
    );
}






// -- Serializing --
// DateTime dateNow = DateTime.Now;

// // object collection
// List<Sales> salesList = new List<Sales>();

// Sales s1 = new Sales(1, "Coral Sand N1", 180.00M, dateNow);
// Sales s2 = new Sales(2, "Samsung Evo 890 Pro 1TB", 1148.00M, dateNow);

// salesList.Add(s1);
// salesList.Add(s2);

// // serializing the list of object
// string serialized = JsonConvert.SerializeObject(salesList, Formatting.Indented);

// File.WriteAllText("Files/sales.json", serialized);

// Console.WriteLine(serialized);
