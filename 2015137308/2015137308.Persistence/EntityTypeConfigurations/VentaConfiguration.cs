using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.EntityTypeConfigurations
{
    public class VentaConfiguration:EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            ToTable("Ventas");
            HasKey(c => c.VentaId);
            HasRequired(c => c.TipoComprobante)
                .WithMany(c => c.Ventas);
            HasRequired(c => c.TipoPago)
                .WithMany(c => c.Ventas);
            HasRequired(c => c.Administrativo)
              .WithMany(c => c.Ventas).HasForeignKey(c => c.EmpleadoId);
            HasRequired(c => c.Servicio)
                .WithMany(c => c.Ventas);
            HasRequired(c => c.Cliente)
                .WithMany(c => c.Ventas);
        }
    }
}
