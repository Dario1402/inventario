using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Entidades
{
    public class MovStock:Base 
    {
        public DateTime DaTime { get; set; }
        public Employee? Carry { get; set; }
        public List<Product>? MaterialModify { get; set; }
    }
}
