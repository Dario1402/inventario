using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Entidades
{
    public class Employee:Base 
    {
        public string Code { set; get; }       
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Area { get; set; }

    }
}
