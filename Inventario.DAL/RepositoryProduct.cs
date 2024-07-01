using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.DAL
{
    internal class RepositoryProduct : IRepository<Product>
    {
        public List<Product> Read => throw new NotImplementedException();

        public bool Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(string Id, Product entityModify)
        {
            throw new NotImplementedException();
        }
    }
}
