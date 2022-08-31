using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Calculator;
using Repository;

namespace WebCalculatorMvc
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IRepositoryService, RepositoryService>();
            container.RegisterType<IStringCalculator, StringCalculator>();
            container.RegisterType<IErrorHandler, ErrorHandler>();
        }
    }
}