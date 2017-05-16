using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.IRepositories
{
    public interface IServicioRepository : IRepository<Servicio>
    {
        IEnumerable<Servicio> GetServicioByLugarViaje(LugarViaje lugarViaje);

        IEnumerable<Servicio> GetServicioByVenta(Venta venta);
    }
}
