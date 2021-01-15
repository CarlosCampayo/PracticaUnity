using Autofac;
using PracticaContainer.Data;
using PracticaContainer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaContainer.App_Start
{
    public static class AutofacConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            // Usually you're only interested in exposing the type
            // via its interface:
            _ = builder.RegisterType<EmpleadosContext>().As<IContextHospital>();

            // However, if you want BOTH services (not as common)
            // you can say so:
            builder.RegisterType<RepositoryEmpleado>().AsSelf().As<IRepositoryHospital>();
        }
    }
}