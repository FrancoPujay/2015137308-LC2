using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2015137308.API.DTO
{
    public class EncomiendaDTO:Servicio
    {
        public string Beneficiario { get; set; }
        public double Peso { get; set; }
    }
}