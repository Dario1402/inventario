using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BIZ
{
    public class ManagerProduct : IManagerProduct
    {
        IRepository<Product> repository;

        public ManagerProduct(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public List<Product> ToList => repository.Read;

        public bool DeleteId(string id)
        {
            return repository.Delete(id);
        }

        public bool Insert(Product entity)
        {
            return repository.Create(entity);
        }

        public bool SelectId(string id)
        {
            return ToList.Where(e => e.Id == id).SingleOrDefault(); 

        }

        public bool Update(Product entity)
        {
            return repository.Update(entity);
        }
    }
}
