using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Interfaces
{
    public interface IManagerMovStock:IManager<MovStock>
    {
        List<MovStock> ToListMovStocks();
        List<MovStock> TolistInterval(DateTime ini, DateTime end);


         
    }
}
