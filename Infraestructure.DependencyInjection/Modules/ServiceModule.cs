using Autofac;
using Services.Implementation.DocumentManagement;
using Services.Interfaces.DocumentManagement.NotaryCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DependencyInjection.Modules
{
    public class ServiceModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            //Autofac
            //Autofac.WepApi2
            //Autofac.Mvc5
            builder.RegisterType<NotaryCompanyManager>().As<INotaryCompanyManager>().InstancePerLifetimeScope(); ;
        }
    }
}
