using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {
        private readonly _2015137308DbContext _Context;

        public ServicioRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }

        public IEnumerable<Servicio> GetServicioByLugarViaje(LugarViaje lugarViaje)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Servicio> GetServicioByVenta(Venta venta)
        {
            throw new NotImplementedException();
        }
        void IRepository<Servicio>.AddRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.Remove(Servicio entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.RemoveRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.Update(Servicio entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Servicio>.UpdateRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }
    }
}
