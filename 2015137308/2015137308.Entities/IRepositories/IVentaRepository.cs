using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.IRepositories
{
    public interface IVentaRepository : IRepository<Venta>
    {
        IEnumerable<Venta> GetClassificatedVentasByTipoComprobante(TipoComprobante tipoComprobante);
        IEnumerable<Venta> GetClassificatedVentasByTipoPago(TipoPago tipoPago);
        IEnumerable<Venta> GetVentaByServicio(Servicio servicio);
        IEnumerable<Venta> GetClassificatedVentasByCliente(Cliente cliente);
    }
}
