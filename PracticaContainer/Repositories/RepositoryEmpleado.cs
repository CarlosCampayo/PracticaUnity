using PracticaContainer.Data;
using PracticaContainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaContainer.Repositories
{
    public class RepositoryEmpleado : IRepositoryHospital
    {
        IContextHospital context;
        public RepositoryEmpleado(IContextHospital context)
        {
            this.context = context;
        }
        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }
    }
}