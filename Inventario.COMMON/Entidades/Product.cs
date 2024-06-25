using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Entidades
{
    internal class Product:Base 
    {
        public int Cod { get; set; }
        public int Codbar { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
       
    }
}
