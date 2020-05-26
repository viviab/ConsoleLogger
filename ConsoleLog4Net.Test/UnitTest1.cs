using System.Runtime.Remoting.Messaging;
using ConsoleLog4Net.Enums;
using ConsoleLog4Net.Facades;
using ConsoleLog4Net.Requests;
using ConsoleLog4Net.Services;
using log4net;
using NUnit.Framework;
using Rhino.Mocks;
using ConsoleLog4Net.Extensions;

namespace ConsoleLog4Net.Test
{
    [TestFixture]
    public class UnitTest1
    {
        private ICustomerFacade _customerFacade;
        private ILog _mockLog;

        [SetUp]
        public void Setup()
        {
            _mockLog = MockRepository.GenerateMock<ILog>();
            _mockLog.Expect(e => e.Debug(Arg<object>.Is.Anything)).Repeat.Once();
            Logger.Log = _mockLog;
            _customerFacade = new CustomerFacade(MockRepository.GenerateMock<ICustomerService>());
        }
        [Test]
        public void TestMethod1()
        {
            var i = 2;
            var result = _customerFacade.GetCustomerId(i);
            
            _mockLog.VerifyAllExpectations();
        }


        public void Test()
        {
            var request = new SearchDevicesRequest();
            request.AddCriteria(SearchCriteriaDto.Active);
        }
    }
}
