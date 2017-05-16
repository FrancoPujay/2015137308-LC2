using _2015137308.Entities.IRepositories;
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
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();
        public IBusRepository Buses { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public IEmpleadoRepository Empleados { get; private set; }
        public ILugarViajeRepository LugarViajes { get; private set; }
        public IServicioRepository Servicios { get; private set; }
        public ITipoComprobanteRepository TipoComprobantes { get; private set; }
        public ITipoLugarRepository TipoLugares { get; private set; }
        public ITipoPagoRepository TipoPagos { get; private set; }
        public ITipoTripulacionRepository TipoTripulaciones { get; private set; }
        public ITipoViajeRepository TipoViajes { get; private set; }
        public IVentaRepository Ventas  { get; private set; }

        public UnityOfWork()
        {
            _Context = new _2015137308DbContext();

            Buses = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            LugarViajes = new LugarViajeRepository(_Context);
            Servicios = new ServicioRepository(_Context);
            TipoComprobantes = new TipoComprobanteRepository(_Context);
            TipoLugares = new TipoLugarRepository(_Context);
            TipoPagos = new TipoPagoRepository(_Context);
            TipoTripulaciones = new TipoTripulacionRepository(_Context);
            TipoViajes = new TipoViajeRepository(_Context);
            Ventas = new VentaRepository(_Context);
        }
        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }

      

        void Dispose()
        {
            _Context.Dispose();
        }

        int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        int IUnityOfWork.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
