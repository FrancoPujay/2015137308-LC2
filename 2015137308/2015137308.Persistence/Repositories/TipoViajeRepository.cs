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
    public class TipoViajeRepository : Repository<TipoViaje>, ITipoViajeRepository
    {
        private _2015137308DbContext _Context;

        public TipoViajeRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }
        void IRepository<TipoViaje>.Add(TipoViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoViaje>.AddRange(IEnumerable<TipoViaje> entities)
        {
            throw new NotImplementedException();
        }


        void IRepository<TipoViaje>.Remove(TipoViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoViaje>.RemoveRange(IEnumerable<TipoViaje> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoViaje>.Update(TipoViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoViaje>.UpdateRange(IEnumerable<TipoViaje> entities)
        {
            throw new NotImplementedException();
        }
    }
}
