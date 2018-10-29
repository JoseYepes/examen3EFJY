using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace Examen_EntityFramework_José_Yepes
{
    public class Ingredients
    {
        private decimal _price; //escribimoscon barra baja para diferenciarlo de price porque es privado

        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Pizzas> Pizzas { get; set; }
        public decimal price {  // decimal para ser mas preciso con los decimales.
            get
            {
                var discount = decimal.Parse(ConfigurationManager.AppSettings["discount"]);// decimal parse convierte a decimal
                return _price * discount;
            }   //  Primero delcaramos appsettings discount en appconfig referenciamos configuration manager.
            set
            {
                price = value;
            }
        }

        
    }
}
