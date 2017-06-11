using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2015137308.API.DTO
{
    public class LugarViajeDTO
    {
        public int LugarViajeId { get; set; }
        public string Descripcion { get; set; }
        public TipoLugar TipoLugar { get; set; }
    }
}