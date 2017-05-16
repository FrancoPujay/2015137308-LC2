using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int TipoComprobanteId { get; set; }
        public int TipoPagoId { get; set; }
        public int EmpleadoId { get; set; }
        public int ClienteId { get; set; }
        public int ServicioId { get; set; }
        public Administrativo Administrativo { get; set; }
        public Cliente Cliente { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        public TipoPago TipoPago { get; set; }
        public Servicio Servicio { get; set; }
        
        public Venta()
        {
            Administrativo = new Administrativo();
            Cliente = new Cliente();
            TipoComprobante = new TipoComprobante();
            TipoPago = new TipoPago();
            Servicio = new Servicio();
        }
    }
}
