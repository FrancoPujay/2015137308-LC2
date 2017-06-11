using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.EntityTypeConfigurations
{
    public class ClienteConfiguration:EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //Table Configurations
            ToTable("Clientes");
            HasKey(c => c.ClienteId);
            Property(c => c.Apellidos)
                .IsRequired()
                .HasMaxLength(255);
            HasMany(t => t.Transportes)
                .WithRequired(t => t.Cliente)
                .HasForeignKey(t => t.ClienteId);
                
        }
    }
}
