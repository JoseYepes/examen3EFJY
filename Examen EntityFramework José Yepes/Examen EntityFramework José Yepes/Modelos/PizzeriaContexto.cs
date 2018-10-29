namespace Examen_EntityFramework_José_Yepes.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PizzeriaContexto : DbContext
    {
        public DbSet<Pizzas> Pizzas { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public PizzeriaContexto()
            : base("name=PizzeriaContexto")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}