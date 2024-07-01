using Inventario.COMMON.Interfaces;
using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.DAL
{
    internal class RepositoryMovStock : IRepository<MovStock>
    {
        public List<MovStock> Read => throw new NotImplementedException();

        public bool Create(MovStock entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, MovStock entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(string Id, MovStock entityModify)
        {
            throw new NotImplementedException();
        }
    }
}
