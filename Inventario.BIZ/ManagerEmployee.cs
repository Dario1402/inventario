using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inventario.BIZ
{
    public class ManagerEmployee:IManagerEmployee
    {
        IRepository<Employee> repository;
        public ManagerEmployee(IRepository<Employee> repo)
        {
            repository = repo;
        }

        public List<Employee> ToList => repository.Read;

        public bool DeleteId(string id)
        {
            return repository.Delete(id);
        }

        public bool Insert(Employee entity)
        {
            return repository.Create(entity);
        }

        public bool SelectId(string id)
        {
            return ToList.Where(e => e.Id == id).SingleOrDefault(); 

        }

        public bool Update(Employee entity)
        {
            return repository.Update(entity);
        }
    }
}
