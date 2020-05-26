using ConsoleLog4Net.Facades;
using ConsoleLog4Net.Services;
using Unity;

namespace ConsoleLog4Net.Dependencies
{
    public static class ContainerExtensions
    {
        public static void MyDependencyInjection(this IUnityContainer container)
        {
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<ICustomerFacade, CustomerFacade>();
        }
    }
}
