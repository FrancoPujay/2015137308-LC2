using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.EntityTypeConfigurations
{
    public class TipoPagoConfiguration:EntityTypeConfiguration<TipoPago>
    {
        public TipoPagoConfiguration()
        {
            //Table Configurations
            ToTable("TipoPagos");
            HasKey(c => c.TipoPagoId);
            Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
