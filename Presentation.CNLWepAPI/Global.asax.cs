using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Infraestructure.DependencyInjection.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Presentation.CNLWepAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Infraestructure.Tranformation.Configuration.InicializarMapas();
            this.InitializeDependencyInjection();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        private void InitializeDependencyInjection()
        {
            var constructor = new ContainerBuilder();
            var configuracion = GlobalConfiguration.Configuration;
            constructor.RegisterApiControllers(Assembly.GetExecutingAssembly());
            constructor.RegisterWebApiFilterProvider(configuracion);
            constructor.RegisterWebApiModelBinderProvider();
            constructor.RegisterModule<ServiceModule>();
            var contenedor = constructor.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contenedor));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(contenedor);
        }
    }
}
