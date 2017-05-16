﻿using _2015137308.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Entities.IRepositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> GetClienteByVenta(Venta venta);

        IEnumerable<Cliente> GetClienteByServicio(Servicio servicio);
    }
}
