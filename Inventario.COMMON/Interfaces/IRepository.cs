using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Interfaces
{
    public interface IRepository<T> where T : Base 
    {
        bool Create(T entity);
        List<T> Read { get; }
        bool Update(string Id, T entityModify);
        bool Delete(string id, T entity);

    }
}
