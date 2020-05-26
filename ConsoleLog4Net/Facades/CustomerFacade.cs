using System;
using ConsoleLog4Net.Services;

namespace ConsoleLog4Net.Facades
{
    public class CustomerFacade : ICustomerFacade
    {
        private readonly ICustomerService _customerService;

        public CustomerFacade(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public int GetCustomerId(int i)
        {
            if (i <= 0)
               throw new ArgumentException("i");

            Logger.Log.Debug("yo");
            return _customerService.GetCustomer(i);
        }
    }
}
