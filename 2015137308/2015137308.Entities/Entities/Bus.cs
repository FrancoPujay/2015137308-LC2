using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Placa { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Servicio> Servicios { get; set; }


        public Bus()
        {

        }

        public Bus(List<Empleado> empleados)
        {
            Empleados =empleados;
        }

        
    }
}
