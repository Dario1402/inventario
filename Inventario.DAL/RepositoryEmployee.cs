

using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.DAL
{
    internal class RepositoryEmployee : IRepository<Employee>
    {
        public List<Employee> Read => throw new NotImplementedException();

        public bool Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int Id, Employee entityModify)
        {
            throw new NotImplementedException();
        }
    }
}
