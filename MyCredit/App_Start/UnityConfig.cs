using System.Web.Http;
using Unity;
using Unity.WebApi;
using Repositories;
using Unity.Injection;

namespace MyCredit
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IGreeter, HiGreeter>("HiController");
            container.RegisterType<IGreeter, HelloGreeter>("HelloController");

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}