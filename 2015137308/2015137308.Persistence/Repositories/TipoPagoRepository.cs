using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class TipoPagoRepository : Repository<TipoPago>, ITipoPagoRepository
    {
        private readonly _2015137308DbContext _Context;

        public TipoPagoRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }
        void IRepository<TipoPago>.AddRange(IEnumerable<TipoPago> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoPago>.Remove(TipoPago entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoPago>.RemoveRange(IEnumerable<TipoPago> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoPago>.Update(TipoPago entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoPago>.UpdateRange(IEnumerable<TipoPago> entities)
        {
            throw new NotImplementedException();
        }
    }
}
