using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Interfaces
{
    public interface IRepository<T> where T : class
    {
        bool Create(T entity);
        List<T> Read { get; }
        bool update(T entity);
        bool delete(T entity);

    }
}
