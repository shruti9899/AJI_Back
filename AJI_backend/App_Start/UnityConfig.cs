using AJI_backend.Repositories;
using AJI_backend.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace AJI_backend
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDepartmentRepo, DepartmentRepo> ();
            container.RegisterType<IEmployeeRepo, EmployeeRepo>();
            container.RegisterType<IEmployeeDept, EmployeeDept>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}