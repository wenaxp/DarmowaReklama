using Castle.Windsor;
using Castle.Windsor.Installer;
using EscortServices.Rest.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;

namespace EscortServices.Rest
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private IWindsorContainer _container;
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            _container = new WindsorContainer().Install(FromAssembly.This());
            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator),
                new WindsorHttpControllerActivator(_container));

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalConfiguration.Configuration);
            CamelCaseConfig.SetFormatting(GlobalConfiguration.Configuration);
        }
    }
}
