using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class TipoTripulacionRepository : Repository<TipoTripulacion>, ITipoTripulacionRepository
    {
        private _2015137308DbContext _Context;

        public TipoTripulacionRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }
        void IRepository<TipoTripulacion>.Add(TipoTripulacion entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoTripulacion>.AddRange(IEnumerable<TipoTripulacion> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoTripulacion>.Remove(TipoTripulacion entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoTripulacion>.RemoveRange(IEnumerable<TipoTripulacion> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoTripulacion>.Update(TipoTripulacion entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoTripulacion>.UpdateRange(IEnumerable<TipoTripulacion> entities)
        {
            throw new NotImplementedException();
        }
    }
}
