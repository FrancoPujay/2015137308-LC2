using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
    {
        private _2015137308DbContext _Context;

        public LugarViajeRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }
        void IRepository<LugarViaje>.AddRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.Remove(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.RemoveRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.Update(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.UpdateRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }
    }
}
