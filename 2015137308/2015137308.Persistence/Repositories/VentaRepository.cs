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
    public class VentaRepository : Repository<Venta>, IVentaRepository
    {
        private readonly _2015137308DbContext _Context;

        public VentaRepository(_2015137308DbContext _Context)
        {
            this._Context = _Context;
        }

        public IEnumerable<Venta> GetClassificatedVentasByCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetClassificatedVentasByTipoComprobante(TipoComprobante tipoComprobante)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetClassificatedVentasByTipoPago(TipoPago tipoPago)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venta> GetVentaByServicio(Servicio servicio)
        {
            throw new NotImplementedException();
        }
        void IRepository<Venta>.Add(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.AddRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Venta> IRepository<Venta>.Find(Expression<Func<Venta, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Venta IRepository<Venta>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.Remove(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.RemoveRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.Update(Venta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Venta>.UpdateRange(IEnumerable<Venta> entities)
        {
            throw new NotImplementedException();
        }
    }
}
