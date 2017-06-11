using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2015137308.API.DTO
{
    public class TripulacionDTO
    {
        [Key]
        public int BusId { get; set; }
        public TipoTripulacion TipoTripulacion { get; set; }
        public Bus Bus { get; set; }
    }
}