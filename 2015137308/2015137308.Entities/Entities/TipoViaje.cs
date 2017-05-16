using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class TipoViaje
    {
        public int TipoViajeId { get; set; }
        public string Descripcion { get; set; }
        public List<Servicio> Servicios { get; set; }
    }
}
