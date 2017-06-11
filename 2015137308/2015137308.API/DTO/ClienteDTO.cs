using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _2015137308.API.DTO
{
    [Table("Clientes")]
    public class ClienteDTO
    {
        
        [Key]
        public int ClienteId { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}