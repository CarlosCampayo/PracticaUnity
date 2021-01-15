using PracticaContainer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticaContainer.Data
{
    public class EmpleadosContext : DbContext, IContextHospital
    {
        public EmpleadosContext() : base("name=conexionhospitalsqlserver") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}