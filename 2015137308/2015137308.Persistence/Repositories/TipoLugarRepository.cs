using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class TipoLugarRepository : Repository<TipoLugar>, ITipoLugarRepository
    {
        private _2015137308DbContext _Context;

        public TipoLugarRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }
        void IRepository<TipoLugar>.AddRange(IEnumerable<TipoLugar> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoLugar>.Remove(TipoLugar entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoLugar>.RemoveRange(IEnumerable<TipoLugar> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoLugar>.Update(TipoLugar entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TipoLugar>.UpdateRange(IEnumerable<TipoLugar> entities)
        {
            throw new NotImplementedException();
        }
    }
}
