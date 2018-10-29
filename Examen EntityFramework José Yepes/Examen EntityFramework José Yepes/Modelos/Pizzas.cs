using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Examen_EntityFramework_José_Yepes
{
    public class Pizzas
    {
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Ingredients> Ingredients { get; set; }   // propiedad  para relacionar las tablas de forma many to many
    }
}
