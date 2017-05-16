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
        
        


        public Transporte()
        {
            Cliente = new Cliente();
            TipoViaje = new TipoViaje();
            LugarViaje = new LugarViaje();
        }
        public override void Service()
        {

            Cliente _Cliente = new Cliente();
            TipoViaje _TipoViaje = new TipoViaje();
            LugarViaje _LugarViaje = new LugarViaje();
            Console.WriteLine("Transporte");
            Console.WriteLine("------------------------------------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        _TipoViaje.Descripcion = ("VIP   ");
                        _Cliente.Nombres = "Hernan";
                        _Cliente.Apellidos = "Torres";
                        _LugarViaje.Descripcion = "Ica"; break;
                    case 1:
                        _TipoViaje.Descripcion = "Normal";
                        _Cliente.Nombres = "Felipe";
                        _Cliente.Apellidos = "Dueñas";
                        _LugarViaje.Descripcion = "Trujillo"; break;
                    default:
                        _TipoViaje.Descripcion = "VIP   ";
                        _Cliente.Nombres = "Isaac";
                        _Cliente.Apellidos = "Morales";
                        _LugarViaje.Descripcion = "Puno"; break;
                }

                Console.WriteLine("" + _Cliente.Nombres + " " + _Cliente.Apellidos + "  Tipo de Viaje: " + _TipoViaje.Descripcion + "   Destino:" + _LugarViaje.Descripcion);
            }

            Console.WriteLine("------------------------------------------------------------------------------");
        }

    }
}
