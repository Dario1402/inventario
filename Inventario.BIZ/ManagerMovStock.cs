using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BIZ
{
    public class ManagerMovStock:IManagerMovStock
    {
        IRepository<MovStock> repository;

        public ManagerMovStock(IRepository<MovStock> repository)
        {
            this.repository = repository;
        }

        public List<MovStock> ToList => repository.Read;

        public bool DeleteId(string id)
        {
            return repository.Delete(id);
        }

        public bool Insert(MovStock entity)
        {
            return repository.Create(entity);
        }

        public bool SelectId(string id)
        {
            return ToList.Where(e => e.Id == id).SingleOrDefault(); 
        }

        public bool Update(MovStock entity)
        {
            return repository.Update(entity);
        }
    }
}
