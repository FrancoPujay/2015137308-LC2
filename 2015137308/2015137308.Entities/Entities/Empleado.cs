using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public TipoTripulacion TipoTripulacion { get; set; }
        public Bus Bus { get; set; }
        
        public Empleado()
        {
            TipoTripulacion = new TipoTripulacion();
        }
    }
}
