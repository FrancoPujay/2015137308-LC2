using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.Entities
{
    public class LugarViaje
    {
        public int LugarViajeId { get; set; }
        public string Descripcion { get; set; }
        public TipoLugar TipoLugar { get; set; }
        public List<Servicio> Servicios { get; set; }
        public LugarViaje()
        {
            TipoLugar = new TipoLugar();
        }
    }    
}
