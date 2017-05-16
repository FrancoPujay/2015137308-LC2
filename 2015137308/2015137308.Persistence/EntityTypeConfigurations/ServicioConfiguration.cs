using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.EntityTypeConfigurations
{
    public class ServicioConfiguration:EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            //Table Configurations
            ToTable("Servicios");

            HasKey(c => c.ServicioId);

            Property(c => c.Tipo)
                .IsRequired()
                .HasMaxLength(255);

            //Relationship Configurations
            Map<Encomienda>(m => m.Requires("Tipo").HasValue("Administrativo"));
            Map<Transporte>(m => m.Requires("Tipo").HasValue("Tripulacion"));

            HasRequired(c => c.LugarViaje)
                .WithMany(c => c.Servicios);

            HasRequired(c => c.Bus)
                .WithMany(c => c.Servicios);

            HasOptional(c => c.Cliente)
               .WithMany(c => c.Servicios);

            HasOptional(c => c.TipoViaje)
               .WithMany(c => c.Servicios);
        }
    }
}
