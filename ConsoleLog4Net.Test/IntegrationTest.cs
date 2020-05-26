using ConsoleLog4Net.Dependencies;
using ConsoleLog4Net.Facades;
using log4net;
using NUnit.Framework;
using Rhino.Mocks;
using Unity;

namespace ConsoleLog4Net.Test
{
    [TestFixture]
    public class IntegrationTest
    {
        private IUnityContainer _container;

        [SetUp]
        public void Setup()
        {
            Logger.Log = MockRepository.GenerateMock<ILog>();
            _container = new UnityContainer();
            _container.MyDependencyInjection();
        }

        [Test]
        public void Test1()
        {
            var customerFacade = _container.Resolve<ICustomerFacade>();
            var i = 4;
            var result = customerFacade.GetCustomerId(i);
            Assert.AreEqual(result, i+1);

        }
    }
}
