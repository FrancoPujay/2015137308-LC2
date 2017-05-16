using _2015137308.Entities.Entities;
using _2015137308.Persistence.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence
{
    public class _2015137308DbContext:DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<TipoTripulacion> TipoTripulaciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<TipoPago> TipoPagos { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<TipoViaje> TipoViajes  { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoLugar> TipoLugares { get; set; }
        public DbSet<LugarViaje> LugarViajes { get; set; }
        public _2015137308DbContext()
			:base("_2015137308")
		{

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new TipoTripulacionConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());
            modelBuilder.Configurations.Add(new TipoComprobanteConfiguration());
            modelBuilder.Configurations.Add(new TipoPagoConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new TipoViajeConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            modelBuilder.Configurations.Add(new TipoLugarConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
