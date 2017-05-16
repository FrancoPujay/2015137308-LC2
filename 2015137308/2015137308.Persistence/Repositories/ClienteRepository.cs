using _2015137308.Entities.Entities;
using _2015137308.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137308.Persistence.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly _2015137308DbContext Context;

        public ClienteRepository(_2015137308DbContext _Context)
        {
            Context = _Context;
        }

        public IEnumerable<Cliente> GetClienteByServicio(Servicio servicio)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetClienteByVenta(Venta venta)
        {
            throw new NotImplementedException();
        }
        void IRepository<Cliente>.AddRange(IEnumerable<Cliente> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cliente>.Remove(Cliente entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cliente>.RemoveRange(IEnumerable<Cliente> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cliente>.Update(Cliente entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cliente>.UpdateRange(IEnumerable<Cliente> entities)
        {
            throw new NotImplementedException();
        }
    }
}
