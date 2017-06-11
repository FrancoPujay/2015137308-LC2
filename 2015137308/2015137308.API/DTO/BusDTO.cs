using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2015137308.API.DTO
{
    public class BusDTO
    {
        [Key]
        public int BusId { get; set; }
        public string Placa { get; set; }
    }
}