using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_EntityFramework_José_Yepes
{
    public static class PagingPizzas

    {
        public static IEnumerable<Pizzas> Page<Pizzas>(this IEnumerable<Pizzas> Pizzas, int page, int pageSize)
        {
            return Pizzas.Skip((page - 1) * pageSize).Take(pageSize);
        }

    }   

