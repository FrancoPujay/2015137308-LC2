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
        public EmpleadoRepository(_2015137308DbContext context) : base(context)
        {

        }
    }
}
