using _2015137308.API.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _2015137308.API
{
    public class APIContext:DbContext
    {
       

        public System.Data.Entity.DbSet<_2015137308.API.DTO.ClienteDTO> Clientes { get; set; }
        public APIContext() : base("API")
        {

        }
    }
}