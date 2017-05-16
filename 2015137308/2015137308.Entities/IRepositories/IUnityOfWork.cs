using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.IRepositories
{
    public interface IUnityOfWork:IDisposable
    {
        IBusRepository Buses { get; }
        IClienteRepository Clientes { get; }
        IEmpleadoRepository Empleados { get; }
        ILugarViajeRepository LugarViajes { get; }
        IServicioRepository Servicios { get; }
        ITipoComprobanteRepository TipoComprobantes { get; }
        ITipoLugarRepository TipoLugares { get; }
        ITipoPagoRepository TipoPagos { get; }
        ITipoTripulacionRepository TipoTripulaciones { get; }
        ITipoViajeRepository TipoViajes { get; }
        IVentaRepository Ventas { get; }
        int SaveChanges();
 
    }
}
