using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class Tripulacion : Empleado
    {
        public int BusId { get; set; }
        public int TipoTripulacionId { get; set; }
        
        public Tripulacion()
        {
            TipoTripulacion = new TipoTripulacion();
        }
    }
}
