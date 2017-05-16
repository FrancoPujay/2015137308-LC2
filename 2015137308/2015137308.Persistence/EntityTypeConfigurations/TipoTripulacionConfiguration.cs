using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.EntityTypeConfigurations
{
    public class TipoTripulacionConfiguration:EntityTypeConfiguration<TipoTripulacion>
    {
        public TipoTripulacionConfiguration()
        {
            //TableConfigurations
            ToTable("TipoTripulaciones");
            HasKey(c => c.TipoTripulacionId);
            Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
