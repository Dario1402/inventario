﻿using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Interfaces
{
    public interface IManagerEmployee:IManager<Employee>
    {
        List<Employee> ToListEmployee();

        List<Employee> ToListEmployee(string area);

    }
}
