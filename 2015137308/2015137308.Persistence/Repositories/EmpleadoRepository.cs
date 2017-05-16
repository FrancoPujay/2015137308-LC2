using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly _2015137308DbContext _Context;

        public EmpleadoRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }

        public IEnumerable<Empleado> GetEmpleadoByBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> GetEmpleadoByTipoTripulacion(TipoTripulacion tipoTripulacion)
        {
            throw new NotImplementedException();
        }
        void IRepository<Empleado>.AddRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.Remove(Empleado entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.RemoveRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.Update(Empleado entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Empleado>.UpdateRange(IEnumerable<Empleado> entities)
        {
            throw new NotImplementedException();
        }
    }
}
