using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Tipo { get; set; }
       
        public Cliente Cliente { get; set; }
        public TipoViaje TipoViaje { get; set; }
        public LugarViaje LugarViaje { get; set; }
        public List<Venta> Ventas { get; set; }
        public Bus Bus { get; set; }
        public virtual void Service() { }
    }
    
}
