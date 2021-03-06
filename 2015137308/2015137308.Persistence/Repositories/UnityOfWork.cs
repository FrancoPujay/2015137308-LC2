﻿using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly _2015137308DbContext _Context;
        public IBusRepository Buses { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public IEmpleadoRepository Empleados { get; private set; }
        public ILugarViajeRepository LugarViajes { get; private set; }
        public IServicioRepository Servicios { get; private set; }
        
        public IVentaRepository Ventas  { get; private set; }

        public UnityOfWork(_2015137308DbContext context)
        {
            _Context = context;

            Buses = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            LugarViajes = new LugarViajeRepository(_Context);
            Servicios = new ServicioRepository(_Context);
            Ventas = new VentaRepository(_Context);
        }
       

      

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }
        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
