using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuget_Serializar_e_Atributos_CSharp.Models
{
    public class Sales
    {

        public Sales(int id, string product, decimal price)
        {
            Id = id;
            Product = product;
            Price = price;
        }


        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
    }
}
