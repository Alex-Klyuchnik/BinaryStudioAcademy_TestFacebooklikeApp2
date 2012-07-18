using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using BinaryStudioAcademy_TestFacebooklikeApp2.DataAccess;
using BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure;

namespace BinaryStudioAcademy_TestFacebooklikeApp2
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Login", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
           Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
           
            
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            SetDependencyResolver();
        }
        private void SetDependencyResolver()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());

            builder
                .RegisterAssemblyTypes(
                    Assembly.GetAssembly(typeof(IIdentifiable)),
                    Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();

            builder.RegisterType<DataRepository>().As<IRepository>().InstancePerHttpRequest();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}