using System;
using ConsoleLog4Net.Facades;

namespace ConsoleLog4Net
{
    public class ProgramStarter
    {
        private readonly ICustomerFacade _customerFacade;

        public ProgramStarter(ICustomerFacade facade)
        {
            _customerFacade = facade;
        }

        public void Run()
        {
            Console.WriteLine(_customerFacade.GetCustomerId(2));
        }
    }
}
