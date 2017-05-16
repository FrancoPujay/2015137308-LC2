using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class TipoComprobanteRepository : Repository<TipoComprobante>, ITipoComprobanteRepository
    {
        private readonly _2015137308DbContext _Context;

        public TipoComprobanteRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }
        void IRepository<TipoComprobante>.AddRange(IEnumerable<TipoComprobante> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoComprobante>.Remove(TipoComprobante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoComprobante>.RemoveRange(IEnumerable<TipoComprobante> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoComprobante>.Update(TipoComprobante entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoComprobante>.UpdateRange(IEnumerable<TipoComprobante> entities)
        {
            throw new NotImplementedException();
        }
    }
}
