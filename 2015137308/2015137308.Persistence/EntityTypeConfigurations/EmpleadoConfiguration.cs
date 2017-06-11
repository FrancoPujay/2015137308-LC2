using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.EntityTypeConfigurations
{
    public class EmpleadoConfiguration:EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguration()
        {
            //Table Configurations
            ToTable("Empleados");

            HasKey(c => c.EmpleadoId);

            
            //Relationship Configurations

            Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativo"));
            Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulacion"));

            
        }
    }
}
