using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Interfaces
{
    public interface IManager<T> where T : Base
    {
        bool Insert(T entity);
        List<T> ToList { get; }
        bool DeleteId(string id);
        bool Update (T entity);
        bool SelectId(string id);

    }
}
