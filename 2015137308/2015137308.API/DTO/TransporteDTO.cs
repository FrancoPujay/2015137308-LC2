using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2015137308.API.DTO
{
    public class TransporteDTO
    {
        [Key]
        public int ClienteId { get; set; }
        public TipoViaje TipoViaje { get; set; }
    }
}