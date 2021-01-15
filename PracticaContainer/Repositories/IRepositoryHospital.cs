using PracticaContainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaContainer.Repositories
{
    public interface IRepositoryHospital
    {
        List<Empleado> GetEmpleados();
    }
}
