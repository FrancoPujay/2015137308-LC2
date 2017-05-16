using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class Transporte : Servicio
    {

        public int BusId { get; set; }
        public int LugarViajeId { get; set; }


        public int ClienteId { get; set; }
        public int TipoViajeId { get; set; }
        
        


        private Transporte()
        {
            Cliente = new Cliente();
            TipoViaje = new TipoViaje();
            LugarViaje = new LugarViaje();
        }

        
    }
}
