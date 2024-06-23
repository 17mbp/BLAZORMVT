using CapaDeDatos;
using CapaNegocio;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<InterfaceTarea, RepositorioTarea>();
            container.RegisterType<InterfaceTa, ClassTa>();
          

            container.RegisterType<InterfaceDA, RepositorioDA>();
            container.RegisterType<Interface, Class1>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}