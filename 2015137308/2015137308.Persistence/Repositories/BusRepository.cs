using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private readonly _2015137308DbContext _Context;

        public BusRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }

        public IEnumerable<Bus> GetBusByEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bus> GetBusWithServicio(Servicio Servicio)
        {
            throw new NotImplementedException();
        }
        void IRepository<Bus>.AddRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Remove(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.RemoveRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Update(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.UpdateRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }
    }
}
