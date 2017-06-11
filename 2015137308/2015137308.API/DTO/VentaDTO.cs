using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2015137308.API.DTO
{
    public class VentaDTO
    {
        [Key]
        public int VentaId { get; set; }
        public int EmpleadoId { get; set; }
        public int ClienteId { get; set; }

        public TipoComprobante TipoComprobante { get; set; }
        public TipoPago TipoPago { get; set; }
        public AdministrativoDTO Administrativo { get; set; }
        public ClienteDTO Cliente { get; set; }
        public Servicio Servicio { get; set; }
    }
}