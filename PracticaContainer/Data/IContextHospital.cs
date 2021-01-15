using PracticaContainer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaContainer.Data
{
    public interface IContextHospital
    {
        DbSet<Empleado> Empleados { get; set; }
    }
}
