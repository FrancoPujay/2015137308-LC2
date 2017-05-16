using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class Encomienda : Servicio
    {
        
        
        


        private Encomienda()
        {
            LugarViaje = new LugarViaje();
        }

        public int BusId { get; set; }
        public int LugarViajeId { get; set; }
        public string Beneficiario { get; set; }
    }
}
