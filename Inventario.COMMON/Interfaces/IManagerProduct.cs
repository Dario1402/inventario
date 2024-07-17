using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Interfaces
{
    public interface IManagerProduct:IManager<Product>
    {
        List<Product> ToListProductCategory(string categoria);

        List<Product> ToListProductCategory();
    }
}
