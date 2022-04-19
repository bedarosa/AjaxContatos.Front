using AjaxContatos.Service.AutoMapper;
using AjaxContatos.Service.Services;
using AjaxContatos.Service.Services.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Lifestyles;
using System.Reflection;
using System.Web.Mvc;

namespace AjaxContatos.Mvc.App_Start
{
    public class SimpleInjectorConfig
    {
        public static void RegisterDIContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }

        private static void InitializeContainer(Container container)
        {
            //container.Register<AjaxContatosContext>(Lifestyle.Scoped);
            container.Register<IContatoService, ContatoService>(Lifestyle.Scoped);

            container.RegisterSingleton(() => AutoMapperConfig.GetMapperConfiguration().CreateMapper(container.GetInstance));
        }
    }
}